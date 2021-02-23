namespace Assignment2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.addNumber1 = new System.Windows.Forms.TextBox();
            this.addNumber2 = new System.Windows.Forms.TextBox();
            this.addNumber3 = new System.Windows.Forms.TextBox();
            this.addName = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.grBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.viewNumber2 = new System.Windows.Forms.TextBox();
            this.viewNumber3 = new System.Windows.Forms.TextBox();
            this.viewNumber1 = new System.Windows.Forms.TextBox();
            this.lbl10 = new System.Windows.Forms.Label();
            this.viewName = new System.Windows.Forms.TextBox();
            this.lbl9 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.contacts = new System.Windows.Forms.DataGridView();
            this.grBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.grBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contacts)).BeginInit();
            this.SuspendLayout();
            // 
            // grBox1
            // 
            this.grBox1.Controls.Add(this.btnAdd);
            this.grBox1.Controls.Add(this.addNumber1);
            this.grBox1.Controls.Add(this.addNumber2);
            this.grBox1.Controls.Add(this.addNumber3);
            this.grBox1.Controls.Add(this.addName);
            this.grBox1.Controls.Add(this.lbl2);
            this.grBox1.Controls.Add(this.lbl1);
            this.grBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBox1.Location = new System.Drawing.Point(18, 12);
            this.grBox1.Name = "grBox1";
            this.grBox1.Size = new System.Drawing.Size(772, 111);
            this.grBox1.TabIndex = 0;
            this.grBox1.TabStop = false;
            this.grBox1.Text = "Add New Contact";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(694, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(46, 47);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // addNumber1
            // 
            this.addNumber1.Location = new System.Drawing.Point(223, 59);
            this.addNumber1.Name = "addNumber1";
            this.addNumber1.Size = new System.Drawing.Size(151, 27);
            this.addNumber1.TabIndex = 1;
            // 
            // addNumber2
            // 
            this.addNumber2.Location = new System.Drawing.Point(380, 59);
            this.addNumber2.Name = "addNumber2";
            this.addNumber2.Size = new System.Drawing.Size(151, 27);
            this.addNumber2.TabIndex = 2;
            // 
            // addNumber3
            // 
            this.addNumber3.Location = new System.Drawing.Point(537, 59);
            this.addNumber3.Name = "addNumber3";
            this.addNumber3.Size = new System.Drawing.Size(151, 27);
            this.addNumber3.TabIndex = 3;
            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(10, 59);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(184, 27);
            this.addName.TabIndex = 0;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(219, 32);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(171, 24);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Contact Numbers";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(6, 32);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(141, 24);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Contact Name";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(13, 138);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(149, 29);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "Contact List";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(206, 142);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(87, 20);
            this.lbl4.TabIndex = 2;
            this.lbl4.Text = "Search for";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(299, 138);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(174, 27);
            this.search.TabIndex = 4;
            // 
            // grBox2
            // 
            this.grBox2.Controls.Add(this.btnDelete);
            this.grBox2.Controls.Add(this.btnUpdate);
            this.grBox2.Controls.Add(this.viewNumber2);
            this.grBox2.Controls.Add(this.viewNumber3);
            this.grBox2.Controls.Add(this.viewNumber1);
            this.grBox2.Controls.Add(this.lbl10);
            this.grBox2.Controls.Add(this.viewName);
            this.grBox2.Controls.Add(this.lbl9);
            this.grBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBox2.Location = new System.Drawing.Point(496, 188);
            this.grBox2.Name = "grBox2";
            this.grBox2.Size = new System.Drawing.Size(294, 261);
            this.grBox2.TabIndex = 7;
            this.grBox2.TabStop = false;
            this.grBox2.Text = "Contact Details";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(193, 217);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 26);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(193, 181);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 27);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // viewNumber2
            // 
            this.viewNumber2.Location = new System.Drawing.Point(10, 177);
            this.viewNumber2.Name = "viewNumber2";
            this.viewNumber2.ReadOnly = true;
            this.viewNumber2.Size = new System.Drawing.Size(177, 27);
            this.viewNumber2.TabIndex = 7;
            // 
            // viewNumber3
            // 
            this.viewNumber3.Location = new System.Drawing.Point(10, 219);
            this.viewNumber3.Name = "viewNumber3";
            this.viewNumber3.ReadOnly = true;
            this.viewNumber3.Size = new System.Drawing.Size(177, 27);
            this.viewNumber3.TabIndex = 8;
            // 
            // viewNumber1
            // 
            this.viewNumber1.Location = new System.Drawing.Point(10, 134);
            this.viewNumber1.Name = "viewNumber1";
            this.viewNumber1.ReadOnly = true;
            this.viewNumber1.Size = new System.Drawing.Size(177, 27);
            this.viewNumber1.TabIndex = 6;
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.Location = new System.Drawing.Point(6, 107);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(171, 24);
            this.lbl10.TabIndex = 7;
            this.lbl10.Text = "Contact Numbers";
            // 
            // viewName
            // 
            this.viewName.Location = new System.Drawing.Point(10, 61);
            this.viewName.Name = "viewName";
            this.viewName.ReadOnly = true;
            this.viewName.Size = new System.Drawing.Size(177, 27);
            this.viewName.TabIndex = 5;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9.Location = new System.Drawing.Point(6, 34);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(141, 24);
            this.lbl9.TabIndex = 1;
            this.lbl9.Text = "Contact Name";
            this.lbl9.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(479, 138);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 31);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.Location = new System.Drawing.Point(313, 180);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(69, 18);
            this.lbl8.TabIndex = 12;
            this.lbl8.Text = "Number3";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(214, 180);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(69, 18);
            this.lbl7.TabIndex = 11;
            this.lbl7.Text = "Number2";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(115, 180);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(69, 18);
            this.lbl6.TabIndex = 10;
            this.lbl6.Text = "Number1";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(12, 180);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(104, 18);
            this.lbl5.TabIndex = 9;
            this.lbl5.Text = "Contact Name";
            // 
            // contacts
            // 
            this.contacts.AllowUserToAddRows = false;
            this.contacts.AllowUserToDeleteRows = false;
            this.contacts.AllowUserToResizeColumns = false;
            this.contacts.AllowUserToResizeRows = false;
            this.contacts.BackgroundColor = System.Drawing.Color.White;
            this.contacts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.contacts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.contacts.ColumnHeadersHeight = 29;
            this.contacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.contacts.ColumnHeadersVisible = false;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.contacts.DefaultCellStyle = dataGridViewCellStyle17;
            this.contacts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.contacts.EnableHeadersVisualStyles = false;
            this.contacts.Location = new System.Drawing.Point(12, 203);
            this.contacts.MultiSelect = false;
            this.contacts.Name = "contacts";
            this.contacts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contacts.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.contacts.RowHeadersVisible = false;
            this.contacts.RowHeadersWidth = 61;
            this.contacts.RowTemplate.Height = 24;
            this.contacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contacts.Size = new System.Drawing.Size(472, 246);
            this.contacts.TabIndex = 16;
            this.contacts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contacts_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 458);
            this.Controls.Add(this.contacts);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.grBox2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.grBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grBox1.ResumeLayout(false);
            this.grBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.grBox2.ResumeLayout(false);
            this.grBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grBox1;
        private System.Windows.Forms.TextBox addNumber1;
        private System.Windows.Forms.TextBox addNumber2;
        private System.Windows.Forms.TextBox addNumber3;
        private System.Windows.Forms.TextBox addName;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.GroupBox grBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox viewNumber2;
        private System.Windows.Forms.TextBox viewNumber3;
        private System.Windows.Forms.TextBox viewNumber1;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.TextBox viewName;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.DataGridView contacts;
    }
}

