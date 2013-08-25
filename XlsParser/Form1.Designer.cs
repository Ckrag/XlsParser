namespace XlsParser
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
            this.parse_xls_btn = new System.Windows.Forms.Button();
            this.openFileDialogXls = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // parse_xls_btn
            // 
            this.parse_xls_btn.Location = new System.Drawing.Point(12, 12);
            this.parse_xls_btn.Name = "parse_xls_btn";
            this.parse_xls_btn.Size = new System.Drawing.Size(75, 23);
            this.parse_xls_btn.TabIndex = 0;
            this.parse_xls_btn.Text = "Parse Xls";
            this.parse_xls_btn.UseVisualStyleBackColor = true;
            this.parse_xls_btn.Click += new System.EventHandler(this.parse_xls_btn_Click);
            // 
            // openFileDialogXls
            // 
            this.openFileDialogXls.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.parse_xls_btn);
            this.Name = "Form1";
            this.Text = "XlsParser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button parse_xls_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialogXls;
    }
}

