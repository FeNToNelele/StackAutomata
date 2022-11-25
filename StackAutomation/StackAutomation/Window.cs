using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackAutomationGUI
{
    public partial class Window : Form
    {
        bool configIsLoaded = false;
        List<string> columnIndices = new List<string>();
        List<string> rowIndices = new List<string>();
        string input;
        Stack<string> stack = new Stack<string>();
        StringBuilder rtbText = new StringBuilder();
        StringBuilder ruleNumbers = new StringBuilder();

        public Window()
        {
            InitializeComponent();
            lblMessage.Text = "";
        }

        private void ReadConfig(string path)
        {
            StreamReader sr;
            try
            {
                sr = new StreamReader(path);
            }
            catch (FileNotFoundException)
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = string.Format("File not found. Path: {0}", path);
                return;
            }
            catch (IOException e)
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = e.Message;
                return;
            } 

            string[] columnIndices = sr.ReadLine().Split(';');
            for (int i = 0; i < columnIndices.Length; i++)
            {
                this.columnIndices.Add(columnIndices[i]);
            }

            SetupDataGridView();

            try
            {
                int rowIndex = 0;
                while (!sr.EndOfStream)
                {
                    string[] row = sr.ReadLine().Split(';');
                    rowIndices.Add(row[0]);

                    string[] config = new string[row.Length - 1];
                    for (int i = 1; i < row.Length; i++)
                    {
                        config[i - 1] = row[i];
                    }
                    dgvConfiguration.Rows.Add(config);
                }
            }
            catch (Exception e)
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = e.Message;
            }
            finally
            {
                sr.Close();
            }

            SetupDataGridViewRowHeaders();
        }

        private void SetupDataGridView()
        {
            dgvConfiguration.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvConfiguration.ColumnCount = this.columnIndices.Count - 1;
            dgvConfiguration.RowHeadersVisible = true;
            dgvConfiguration.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

            for (int i = 1; i < columnIndices.Count; i++)
            {
                dgvConfiguration.Columns[i - 1].Name = this.columnIndices[i];
            }
        }
        private void SetupDataGridViewRowHeaders()
        {
            int rowNumber = 1;
            foreach (DataGridViewRow row in dgvConfiguration.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }
                row.HeaderCell.Value = rowIndices[rowNumber - 1];
                rowNumber++;
            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbPath.Text = openFileDialog.FileName;
            }
        }

        private void btnAnalise_Click(object sender, EventArgs e)
        {
            rtbSteps.Text = "";
            ruleNumbers.Clear();

            if (string.IsNullOrEmpty(tbInput.Text) || string.IsNullOrEmpty(tbPath.Text))
            {
                lblMessage.ForeColor = Color.Orange;
                lblMessage.Text = "Please fill all fields.";
                return;
            }

            this.input = tbInput.Text;

            if (configIsLoaded)
            {
                AnaliseInput();
            }
            else
            {
                lblMessage.ForeColor = Color.Orange;
                lblMessage.Text = "Please load the config first.";
            }
        }

        private void AnaliseInput()
        {
            rtbText.Clear();
            stack.Clear();
            stack.Push("#");
            stack.Push(rowIndices[0]);
            try
            {
                SimplifyInput();
            }
            catch (InvalidDataException)
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Input has syntax error.";
                return;
            }

            RunAutomata();
        }

        private void RunAutomata()
        {
            int i = 0;
            while (i < input.Length)
            {
                string topOfStack = stack.Pop();
                char charFromInput = input[i];

                if (ruleNumbers.ToString() == "1")
                {
                    int a = 0;
                }

                int columnIndex = columnIndices.IndexOf(charFromInput.ToString());
                int rowIndex = rowIndices.IndexOf(topOfStack);

                string nextRule = dgvConfiguration[columnIndex - 1, rowIndex].Value.ToString();

                string[] splittedRule = nextRule.Split(',');

                if (string.IsNullOrEmpty(splittedRule[0]))
                {
                    lblMessage.ForeColor = Color.Orange;
                    lblMessage.Text = string.Format("Input is invalid at position {0}", i);
                    return;
                }
                else if (splittedRule[0] == "accept")
                {
                    lblMessage.ForeColor = Color.Green;
                    lblMessage.Text = "Input is accepted.";
                    return;
                }
                else if (splittedRule[0] == "pop")
                {
                    i++;
                    continue;
                }
                else if (splittedRule[0] == "epsilon")
                {
                }
                else
                {
                    for (int j = splittedRule[0].Length - 1; j >= 0; j--)
                    {
                        if (splittedRule[0][j] == '\'')
                        {
                            stack.Push(
                                string.Format("{0}{1}", splittedRule[0][j - 1], splittedRule[0][j]));
                            j--;
                        }
                        else
                        {
                            stack.Push(splittedRule[0][j].ToString());
                        }
                    }
                }

                if (splittedRule.Length == 2)
                {
                    ruleNumbers.Append(splittedRule[1]);
                    UpdateRichTextBox(i);
                }
            }
        }

        private void UpdateRichTextBox(int startIndexForInput)
        {
            string restInput = string.Empty;
            for (int i = startIndexForInput; i < this.input.Length; i++)
            {
                restInput += this.input[i];
            }

            string stackContent = string.Empty;
            for (int i = 0; i < stack.Count; i++)
            {
                stackContent += stack.ElementAt(i);
            }

            rtbText.Append(string.Format("({0},\t{1}, {2})\n",
                restInput, stackContent, ruleNumbers.ToString()));
            rtbSteps.Text = rtbText.ToString();
        }

        void SimplifyInput()
        {
            this.input = Regex.Replace(this.input, "[0-9]+", "i");
            if (!this.input.Contains('#'))
            {
                this.input += '#';
            }
        }

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPath.Text))
            {
                lblMessage.ForeColor = Color.Orange;
                lblMessage.Text = "No config is given.";
                return;
            }

            ClearAllInput();

            ReadConfig(tbPath.Text);
            configIsLoaded = true;

            lblMessage.ForeColor = Color.Green;
            lblMessage.Text = "Config has been loaded successfully.";
        }

        private void ClearAllInput()
        {
            ruleNumbers.Clear();
            columnIndices.Clear();
            rowIndices.Clear();
            dgvConfiguration.DataSource = null;
            dgvConfiguration.Rows.Clear();
            dgvConfiguration.Columns.Clear();
            dgvConfiguration.Refresh();
        }
    }
}
