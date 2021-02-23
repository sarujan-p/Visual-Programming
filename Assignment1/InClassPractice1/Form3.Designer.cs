namespace InClassPractice1
{
    partial class Form3
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
            this.lbYear = new System.Windows.Forms.Label();
            this.lbCourseCode = new System.Windows.Forms.Label();
            this.lbCredit = new System.Windows.Forms.Label();
            this.lbGrade = new System.Windows.Forms.Label();
            this.addbtn1 = new System.Windows.Forms.Button();
            this.CourseCode = new System.Windows.Forms.TextBox();
            this.Credit = new System.Windows.Forms.TextBox();
            this.Grade = new System.Windows.Forms.TextBox();
            this.cb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marks of the Student:";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYear.Location = new System.Drawing.Point(61, 78);
            this.lbYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(38, 17);
            this.lbYear.TabIndex = 1;
            this.lbYear.Text = "Year";
            // 
            // lbCourseCode
            // 
            this.lbCourseCode.AutoSize = true;
            this.lbCourseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourseCode.Location = new System.Drawing.Point(5, 121);
            this.lbCourseCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCourseCode.Name = "lbCourseCode";
            this.lbCourseCode.Size = new System.Drawing.Size(92, 17);
            this.lbCourseCode.TabIndex = 2;
            this.lbCourseCode.Text = "Course  code";
            // 
            // lbCredit
            // 
            this.lbCredit.AutoSize = true;
            this.lbCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCredit.Location = new System.Drawing.Point(53, 156);
            this.lbCredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCredit.Name = "lbCredit";
            this.lbCredit.Size = new System.Drawing.Size(45, 17);
            this.lbCredit.TabIndex = 3;
            this.lbCredit.Text = "Credit";
            // 
            // lbGrade
            // 
            this.lbGrade.AutoSize = true;
            this.lbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrade.Location = new System.Drawing.Point(51, 193);
            this.lbGrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(48, 17);
            this.lbGrade.TabIndex = 4;
            this.lbGrade.Text = "Grade";
            this.lbGrade.Click += new System.EventHandler(this.lbGrade_Click);
            // 
            // addbtn1
            // 
            this.addbtn1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addbtn1.Location = new System.Drawing.Point(169, 236);
            this.addbtn1.Margin = new System.Windows.Forms.Padding(4);
            this.addbtn1.Name = "addbtn1";
            this.addbtn1.Size = new System.Drawing.Size(100, 28);
            this.addbtn1.TabIndex = 5;
            this.addbtn1.Text = "ADD";
            this.addbtn1.UseVisualStyleBackColor = false;
            this.addbtn1.Click += new System.EventHandler(this.addbtn1_Click);
            // 
            // CourseCode
            // 
            this.CourseCode.Location = new System.Drawing.Point(107, 117);
            this.CourseCode.Margin = new System.Windows.Forms.Padding(4);
            this.CourseCode.Name = "CourseCode";
            this.CourseCode.Size = new System.Drawing.Size(157, 22);
            this.CourseCode.TabIndex = 6;
            // 
            // Credit
            // 
            this.Credit.Location = new System.Drawing.Point(107, 153);
            this.Credit.Margin = new System.Windows.Forms.Padding(4);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(157, 22);
            this.Credit.TabIndex = 7;
            // 
            // Grade
            // 
            this.Grade.Location = new System.Drawing.Point(108, 193);
            this.Grade.Margin = new System.Windows.Forms.Padding(4);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(157, 22);
            this.Grade.TabIndex = 8;
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Items.AddRange(new object[] {
            "Year-1",
            "Year-2",
            "Year-3",
            "Year-4"});
            this.cb.Location = new System.Drawing.Point(108, 74);
            this.cb.Margin = new System.Windows.Forms.Padding(4);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(156, 24);
            this.cb.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 297);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.CourseCode);
            this.Controls.Add(this.addbtn1);
            this.Controls.Add(this.lbGrade);
            this.Controls.Add(this.lbCredit);
            this.Controls.Add(this.lbCourseCode);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add...";
            this.Load += new System.EventHandler(this.addbtn1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbCourseCode;
        private System.Windows.Forms.Label lbCredit;
        private System.Windows.Forms.Label lbGrade;
        private System.Windows.Forms.Button addbtn1;
        private System.Windows.Forms.TextBox CourseCode;
        private System.Windows.Forms.TextBox Credit;
        private System.Windows.Forms.TextBox Grade;
        private System.Windows.Forms.ComboBox cb;
    }
}