namespace StackAutomationGUI
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvConfiguration = new System.Windows.Forms.DataGridView();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblConfig = new System.Windows.Forms.Label();
            this.btnAnalise = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.rtbSteps = new System.Windows.Forms.RichTextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnLoadConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfiguration)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConfiguration
            // 
            this.dgvConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConfiguration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConfiguration.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvConfiguration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfiguration.Location = new System.Drawing.Point(12, 12);
            this.dgvConfiguration.Name = "dgvConfiguration";
            this.dgvConfiguration.Size = new System.Drawing.Size(680, 480);
            this.dgvConfiguration.StandardTab = true;
            this.dgvConfiguration.TabIndex = 0;
            // 
            // lblInput
            // 
            this.lblInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblInput.Location = new System.Drawing.Point(698, 21);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(56, 24);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Input:";
            // 
            // lblConfig
            // 
            this.lblConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfig.AutoSize = true;
            this.lblConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblConfig.Location = new System.Drawing.Point(698, 58);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(110, 24);
            this.lblConfig.TabIndex = 2;
            this.lblConfig.Text = "Config path:";
            // 
            // btnAnalise
            // 
            this.btnAnalise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAnalise.Location = new System.Drawing.Point(1008, 104);
            this.btnAnalise.Name = "btnAnalise";
            this.btnAnalise.Size = new System.Drawing.Size(110, 45);
            this.btnAnalise.TabIndex = 3;
            this.btnAnalise.Text = "Analise";
            this.btnAnalise.UseVisualStyleBackColor = true;
            this.btnAnalise.Click += new System.EventHandler(this.btnAnalise_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMessage.Location = new System.Drawing.Point(698, 160);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(285, 24);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Any message from the algorithm.";
            // 
            // rtbSteps
            // 
            this.rtbSteps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSteps.Enabled = false;
            this.rtbSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtbSteps.Location = new System.Drawing.Point(702, 187);
            this.rtbSteps.Name = "rtbSteps";
            this.rtbSteps.Size = new System.Drawing.Size(550, 305);
            this.rtbSteps.TabIndex = 5;
            this.rtbSteps.Text = "";
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Location = new System.Drawing.Point(814, 25);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(438, 20);
            this.tbInput.TabIndex = 6;
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.Location = new System.Drawing.Point(814, 62);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(304, 20);
            this.tbPath.TabIndex = 7;
            // 
            // btnPath
            // 
            this.btnPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPath.Location = new System.Drawing.Point(1124, 62);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(36, 24);
            this.btnPath.TabIndex = 8;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLoadConfig.Location = new System.Drawing.Point(814, 104);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new System.Drawing.Size(110, 45);
            this.btnLoadConfig.TabIndex = 9;
            this.btnLoadConfig.Text = "Load config";
            this.btnLoadConfig.UseVisualStyleBackColor = true;
            this.btnLoadConfig.Click += new System.EventHandler(this.btnLoadConfig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 505);
            this.Controls.Add(this.btnLoadConfig);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.rtbSteps);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnAnalise);
            this.Controls.Add(this.lblConfig);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.dgvConfiguration);
            this.Name = "Form1";
            this.Text = "StackAutomata";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfiguration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConfiguration;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.Button btnAnalise;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.RichTextBox rtbSteps;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnLoadConfig;
    }
}

