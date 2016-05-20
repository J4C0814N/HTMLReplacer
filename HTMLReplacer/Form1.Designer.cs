namespace HTMLReplacer
{
    partial class Form1
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
            this.txtInputAsCode = new System.Windows.Forms.TextBox();
            this.txtOutputAsCode = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSaveOutput = new System.Windows.Forms.Button();
            this.cbxReplaceSelection = new System.Windows.Forms.ComboBox();
            this.btnCopyOutToIn = new System.Windows.Forms.Button();
            this.cbxHTMLOptions = new System.Windows.Forms.ComboBox();
            this.gbxOptions = new System.Windows.Forms.GroupBox();
            this.rbGiveLabelForInputId = new System.Windows.Forms.RadioButton();
            this.gbxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInputAsCode
            // 
            this.txtInputAsCode.Location = new System.Drawing.Point(13, 110);
            this.txtInputAsCode.Multiline = true;
            this.txtInputAsCode.Name = "txtInputAsCode";
            this.txtInputAsCode.Size = new System.Drawing.Size(356, 497);
            this.txtInputAsCode.TabIndex = 0;
            // 
            // txtOutputAsCode
            // 
            this.txtOutputAsCode.Location = new System.Drawing.Point(412, 110);
            this.txtOutputAsCode.Multiline = true;
            this.txtOutputAsCode.Name = "txtOutputAsCode";
            this.txtOutputAsCode.Size = new System.Drawing.Size(356, 497);
            this.txtOutputAsCode.TabIndex = 0;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(376, 363);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(30, 23);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = ">>";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(13, 613);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import File";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSaveOutput
            // 
            this.btnSaveOutput.Location = new System.Drawing.Point(692, 614);
            this.btnSaveOutput.Name = "btnSaveOutput";
            this.btnSaveOutput.Size = new System.Drawing.Size(75, 23);
            this.btnSaveOutput.TabIndex = 3;
            this.btnSaveOutput.Text = "Save Output";
            this.btnSaveOutput.UseVisualStyleBackColor = true;
            // 
            // cbxReplaceSelection
            // 
            this.cbxReplaceSelection.Enabled = false;
            this.cbxReplaceSelection.FormattingEnabled = true;
            this.cbxReplaceSelection.Location = new System.Drawing.Point(13, 55);
            this.cbxReplaceSelection.Name = "cbxReplaceSelection";
            this.cbxReplaceSelection.Size = new System.Drawing.Size(356, 21);
            this.cbxReplaceSelection.TabIndex = 4;
            // 
            // btnCopyOutToIn
            // 
            this.btnCopyOutToIn.Location = new System.Drawing.Point(412, 613);
            this.btnCopyOutToIn.Name = "btnCopyOutToIn";
            this.btnCopyOutToIn.Size = new System.Drawing.Size(84, 23);
            this.btnCopyOutToIn.TabIndex = 5;
            this.btnCopyOutToIn.Text = "Copy to Import";
            this.btnCopyOutToIn.UseVisualStyleBackColor = true;
            this.btnCopyOutToIn.Click += new System.EventHandler(this.btnCopyOutToIn_Click);
            // 
            // cbxHTMLOptions
            // 
            this.cbxHTMLOptions.Enabled = false;
            this.cbxHTMLOptions.FormattingEnabled = true;
            this.cbxHTMLOptions.Location = new System.Drawing.Point(13, 28);
            this.cbxHTMLOptions.Name = "cbxHTMLOptions";
            this.cbxHTMLOptions.Size = new System.Drawing.Size(151, 21);
            this.cbxHTMLOptions.TabIndex = 4;
            // 
            // gbxOptions
            // 
            this.gbxOptions.Controls.Add(this.rbGiveLabelForInputId);
            this.gbxOptions.Location = new System.Drawing.Point(412, 28);
            this.gbxOptions.Name = "gbxOptions";
            this.gbxOptions.Size = new System.Drawing.Size(355, 76);
            this.gbxOptions.TabIndex = 6;
            this.gbxOptions.TabStop = false;
            // 
            // rbGiveLabelForInputId
            // 
            this.rbGiveLabelForInputId.AutoSize = true;
            this.rbGiveLabelForInputId.Checked = true;
            this.rbGiveLabelForInputId.Location = new System.Drawing.Point(7, 7);
            this.rbGiveLabelForInputId.Name = "rbGiveLabelForInputId";
            this.rbGiveLabelForInputId.Size = new System.Drawing.Size(144, 17);
            this.rbGiveLabelForInputId.TabIndex = 0;
            this.rbGiveLabelForInputId.TabStop = true;
            this.rbGiveLabelForInputId.Text = "Give <label for=[InputId]>";
            this.rbGiveLabelForInputId.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 664);
            this.Controls.Add(this.gbxOptions);
            this.Controls.Add(this.btnCopyOutToIn);
            this.Controls.Add(this.cbxHTMLOptions);
            this.Controls.Add(this.cbxReplaceSelection);
            this.Controls.Add(this.btnSaveOutput);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtOutputAsCode);
            this.Controls.Add(this.txtInputAsCode);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxOptions.ResumeLayout(false);
            this.gbxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputAsCode;
        private System.Windows.Forms.TextBox txtOutputAsCode;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSaveOutput;
        private System.Windows.Forms.ComboBox cbxReplaceSelection;
        private System.Windows.Forms.Button btnCopyOutToIn;
        private System.Windows.Forms.ComboBox cbxHTMLOptions;
        private System.Windows.Forms.GroupBox gbxOptions;
        private System.Windows.Forms.RadioButton rbGiveLabelForInputId;
    }
}

