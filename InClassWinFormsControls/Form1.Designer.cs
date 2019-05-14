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
            this.btnClearYears = new System.Windows.Forms.Button();
            this.radStaff = new System.Windows.Forms.RadioButton();
            this.radStudent = new System.Windows.Forms.RadioButton();
            this.radFaculty = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // btnClearYears
            // 
            this.btnClearYears.Location = new System.Drawing.Point(279, 72);
            this.btnClearYears.Name = "btnClearYears";
            this.btnClearYears.Size = new System.Drawing.Size(105, 55);
            this.btnClearYears.TabIndex = 1;
            this.btnClearYears.Text = "Clear";
            this.btnClearYears.UseVisualStyleBackColor = true;
            this.btnClearYears.Click += new System.EventHandler(this.btnClearYears_Click);
            // 
            // radStaff
            // 
            this.radStaff.AutoSize = true;
            this.radStaff.Location = new System.Drawing.Point(27, 50);
            this.radStaff.Name = "radStaff";
            this.radStaff.Size = new System.Drawing.Size(47, 17);
            this.radStaff.TabIndex = 2;
            this.radStaff.TabStop = true;
            this.radStaff.Text = "Staff";
            this.radStaff.UseVisualStyleBackColor = true;
            this.radStaff.CheckedChanged += new System.EventHandler(this.radStaff_CheckedChanged);
            // 
            // radStudent
            // 
            this.radStudent.AutoSize = true;
            this.radStudent.Location = new System.Drawing.Point(27, 78);
            this.radStudent.Name = "radStudent";
            this.radStudent.Size = new System.Drawing.Size(62, 17);
            this.radStudent.TabIndex = 3;
            this.radStudent.TabStop = true;
            this.radStudent.Text = "Student";
            this.radStudent.UseVisualStyleBackColor = true;
            this.radStudent.CheckedChanged += new System.EventHandler(this.radStudent_CheckedChanged);
            // 
            // radFaculty
            // 
            this.radFaculty.AutoSize = true;
            this.radFaculty.Location = new System.Drawing.Point(27, 22);
            this.radFaculty.Name = "radFaculty";
            this.radFaculty.Size = new System.Drawing.Size(59, 17);
            this.radFaculty.TabIndex = 4;
            this.radFaculty.TabStop = true;
            this.radFaculty.Text = "Faculty";
            this.radFaculty.UseVisualStyleBackColor = true;
            this.radFaculty.CheckedChanged += new System.EventHandler(this.radFaculty_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(28, 31);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(28, 55);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(28, 78);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(85, 17);
            this.radioButton6.TabIndex = 7;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(479, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 120);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radFaculty);
            this.groupBox2.Controls.Add(this.radStaff);
            this.groupBox2.Controls.Add(this.radStudent);
            this.groupBox2.Location = new System.Drawing.Point(479, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 120);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearYears);
            this.Controls.Add(this.cboExpYear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboExpYear;
        private System.Windows.Forms.Button btnClearYears;
        private System.Windows.Forms.RadioButton radStaff;
        private System.Windows.Forms.RadioButton radStudent;
        private System.Windows.Forms.RadioButton radFaculty;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

