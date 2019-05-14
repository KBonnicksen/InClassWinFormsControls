namespace InClassWinFormsControls
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
            this.cboExpYear = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboExpYear
            // 
            this.cboExpYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExpYear.FormattingEnabled = true;
            this.cboExpYear.Location = new System.Drawing.Point(84, 72);
            this.cboExpYear.Name = "cboExpYear";
            this.cboExpYear.Size = new System.Drawing.Size(156, 21);
            this.cboExpYear.TabIndex = 0;
            this.cboExpYear.SelectedIndexChanged += new System.EventHandler(this.cboExpYear_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboExpYear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboExpYear;
    }
}

