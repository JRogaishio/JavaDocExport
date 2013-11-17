namespace JavaDocExport
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_importFile = new System.Windows.Forms.Button();
            this.lbl_importFile = new System.Windows.Forms.Label();
            this.btn_exportDir = new System.Windows.Forms.Button();
            this.lbl_exportDir = new System.Windows.Forms.Label();
            this.cbo_exportType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_export = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File to Export:";
            // 
            // btn_importFile
            // 
            this.btn_importFile.Location = new System.Drawing.Point(12, 78);
            this.btn_importFile.Name = "btn_importFile";
            this.btn_importFile.Size = new System.Drawing.Size(148, 23);
            this.btn_importFile.TabIndex = 1;
            this.btn_importFile.Text = "Select a File";
            this.btn_importFile.UseVisualStyleBackColor = true;
            this.btn_importFile.Click += new System.EventHandler(this.btn_importFile_Click);
            // 
            // lbl_importFile
            // 
            this.lbl_importFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_importFile.Location = new System.Drawing.Point(16, 104);
            this.lbl_importFile.Name = "lbl_importFile";
            this.lbl_importFile.Size = new System.Drawing.Size(311, 23);
            this.lbl_importFile.TabIndex = 2;
            this.lbl_importFile.Text = "no file selected";
            // 
            // btn_exportDir
            // 
            this.btn_exportDir.Location = new System.Drawing.Point(16, 158);
            this.btn_exportDir.Name = "btn_exportDir";
            this.btn_exportDir.Size = new System.Drawing.Size(148, 23);
            this.btn_exportDir.TabIndex = 3;
            this.btn_exportDir.Text = "Select a directory to Export";
            this.btn_exportDir.UseVisualStyleBackColor = true;
            this.btn_exportDir.Click += new System.EventHandler(this.btn_exportDir_Click);
            // 
            // lbl_exportDir
            // 
            this.lbl_exportDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_exportDir.Location = new System.Drawing.Point(16, 184);
            this.lbl_exportDir.Name = "lbl_exportDir";
            this.lbl_exportDir.Size = new System.Drawing.Size(311, 23);
            this.lbl_exportDir.TabIndex = 4;
            this.lbl_exportDir.Text = "no file selected";
            // 
            // cbo_exportType
            // 
            this.cbo_exportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_exportType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbo_exportType.FormattingEnabled = true;
            this.cbo_exportType.Items.AddRange(new object[] {
            "HTML",
            "TEXT"});
            this.cbo_exportType.Location = new System.Drawing.Point(16, 235);
            this.cbo_exportType.Name = "cbo_exportType";
            this.cbo_exportType.Size = new System.Drawing.Size(121, 21);
            this.cbo_exportType.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Export to Folder:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Export Format:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "JavaDoc Exporter";
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.Lime;
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.Location = new System.Drawing.Point(16, 292);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(311, 51);
            this.btn_export.TabIndex = 9;
            this.btn_export.Text = "EXPORT!";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 357);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_exportType);
            this.Controls.Add(this.lbl_exportDir);
            this.Controls.Add(this.btn_exportDir);
            this.Controls.Add(this.lbl_importFile);
            this.Controls.Add(this.btn_importFile);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "JavaDoc Exporter";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_importFile;
        private System.Windows.Forms.Label lbl_importFile;
        private System.Windows.Forms.Button btn_exportDir;
        private System.Windows.Forms.Label lbl_exportDir;
        public System.Windows.Forms.ComboBox cbo_exportType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_export;
    }
}

