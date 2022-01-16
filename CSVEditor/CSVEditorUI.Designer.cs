﻿namespace CSVEditor
{
    partial class CSVEditorUI
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
            this.dgvCSVOutput = new System.Windows.Forms.DataGridView();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSLFileStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.chkAddQuotationMarks = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSVOutput)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCSVOutput
            // 
            this.dgvCSVOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCSVOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCSVOutput.Location = new System.Drawing.Point(9, 39);
            this.dgvCSVOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCSVOutput.Name = "dgvCSVOutput";
            this.dgvCSVOutput.RowTemplate.Height = 24;
            this.dgvCSVOutput.Size = new System.Drawing.Size(582, 293);
            this.dgvCSVOutput.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(9, 10);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(65, 24);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(79, 10);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 24);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Current File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLFileStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(600, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSLFileStatus
            // 
            this.TSSLFileStatus.Name = "TSSLFileStatus";
            this.TSSLFileStatus.Size = new System.Drawing.Size(86, 17);
            this.TSSLFileStatus.Text = "No File Loaded";
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Enabled = false;
            this.btnSaveAs.Location = new System.Drawing.Point(185, 10);
            this.btnSaveAs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(64, 24);
            this.btnSaveAs.TabIndex = 4;
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.BtnSaveAs_Click);
            // 
            // chkAddQuotationMarks
            // 
            this.chkAddQuotationMarks.AutoSize = true;
            this.chkAddQuotationMarks.Location = new System.Drawing.Point(274, 10);
            this.chkAddQuotationMarks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkAddQuotationMarks.Name = "chkAddQuotationMarks";
            this.chkAddQuotationMarks.Size = new System.Drawing.Size(132, 17);
            this.chkAddQuotationMarks.TabIndex = 5;
            this.chkAddQuotationMarks.Text = "Add Quotation Marks+";
            this.chkAddQuotationMarks.UseVisualStyleBackColor = true;
            // 
            // CSVEditorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.chkAddQuotationMarks);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.dgvCSVOutput);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CSVEditorUI";
            this.Text = "CSV Editor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSVOutput)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCSVOutput;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSSLFileStatus;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.CheckBox chkAddQuotationMarks;
    }
}

