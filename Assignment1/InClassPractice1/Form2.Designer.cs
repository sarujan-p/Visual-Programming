namespace InClassPractice1
{
    partial class Form2
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Year 1", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Year 2", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Year 3", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Year 4", System.Windows.Forms.HorizontalAlignment.Left);
            this.lb2 = new System.Windows.Forms.Label();
            this.lbStNo = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.lv = new System.Windows.Forms.ListView();
            this.CourseCode_h = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Credit_h = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grade_h = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(0, 11);
            this.lb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(108, 20);
            this.lb2.TabIndex = 0;
            this.lb2.Text = "Student No:";
            // 
            // lbStNo
            // 
            this.lbStNo.AutoSize = true;
            this.lbStNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStNo.ForeColor = System.Drawing.Color.IndianRed;
            this.lbStNo.Location = new System.Drawing.Point(116, 11);
            this.lbStNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStNo.Name = "lbStNo";
            this.lbStNo.Size = new System.Drawing.Size(99, 20);
            this.lbStNo.TabIndex = 1;
            this.lbStNo.Text = "#########";
            this.lbStNo.Click += new System.EventHandler(this.lbStNo_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addbtn.Location = new System.Drawing.Point(366, 5);
            this.addbtn.Margin = new System.Windows.Forms.Padding(4);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(97, 37);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Calculate.Location = new System.Drawing.Point(763, 5);
            this.Calculate.Margin = new System.Windows.Forms.Padding(4);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(120, 37);
            this.Calculate.TabIndex = 3;
            this.Calculate.Text = "CALCULATE";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CourseCode_h,
            this.Credit_h,
            this.Grade_h});
            listViewGroup1.Header = "Year 1";
            listViewGroup1.Name = "Year 1";
            listViewGroup2.Header = "Year 2";
            listViewGroup2.Name = "Year 2";
            listViewGroup3.Header = "Year 3";
            listViewGroup3.Name = "Year 3";
            listViewGroup4.Header = "Year 4";
            listViewGroup4.Name = "Year 4";
            this.lv.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(7, 50);
            this.lv.Margin = new System.Windows.Forms.Padding(4);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(456, 478);
            this.lv.TabIndex = 4;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // CourseCode_h
            // 
            this.CourseCode_h.Text = "Course Code";
            this.CourseCode_h.Width = 110;
            // 
            // Credit_h
            // 
            this.Credit_h.Text = "Credit";
            this.Credit_h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Credit_h.Width = 80;
            // 
            // Grade_h
            // 
            this.Grade_h.Text = "Grade";
            this.Grade_h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Grade_h.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(201, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(567, 171);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(241, 217);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 5;
            this.pic.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 530);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbStNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPA Calculator";
            this.Load += new System.EventHandler(this.lbStNo_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lbStNo;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader CourseCode_h;
        private System.Windows.Forms.ColumnHeader Credit_h;
        private System.Windows.Forms.ColumnHeader Grade_h;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic;
    }
}