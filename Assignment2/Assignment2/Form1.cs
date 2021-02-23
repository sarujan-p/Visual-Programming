using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        int selectedData;
        private void Form1_Load(object sender, EventArgs e)
        {
            start();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            add();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete();
        }
        private void contacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            view(e);
        }
        private void start()
        {
            table.Columns.Add("Name",typeof(string));
            table.Columns.Add("Number1", typeof(string));
            table.Columns.Add("Number2", typeof(string));
            table.Columns.Add("Number3", typeof(string));

            contacts.DataSource = table;

            load_old_data();
        }
        private void load_old_data()
        {
            StreamReader txt_file = new StreamReader("phonebook.txt");

            string new_row;
            while ((new_row = txt_file.ReadLine()) != null)
            {
                DataRow dataRow = table.NewRow();

                string[] values = new_row.Split('|');
                for (int z = 0; z < values.Length; z++)
                {
                    dataRow[z] = values[z];
                }
                table.Rows.Add(dataRow);

            }
            txt_file.Close();
            contacts.DataSource = table;
        }
        private void add()
        {
            table.Rows.Add(addName.Text, addNumber1.Text, addNumber2.Text, addNumber3.Text);
            contacts.DataSource = table;

            add_clear();

            MessageBox.Show("Contact Added to your contact list!", "Success");

            save_to_txt();
        }
        private void view(DataGridViewCellEventArgs e)
        {
            selectedData = e.RowIndex;
            DataGridViewRow row = contacts.Rows[selectedData];
            viewName.Text = row.Cells[0].Value.ToString();
            viewNumber1.Text = row.Cells[1].Value.ToString();
            viewNumber2.Text = row.Cells[2].Value.ToString();
            viewNumber3.Text = row.Cells[3].Value.ToString();

            read_only_false();
        }
        private void save_to_txt()
        {
            TextWriter writer = new StreamWriter("phonebook.txt");
            int i = 0;
            for (i = 0; i <= contacts.Rows.Count - 1; i++)
            {
                int j = 0;
                for (j = 0; j < contacts.Columns.Count-1; j++)
                {
                    writer.Write(contacts.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.Write(contacts.Rows[i].Cells[j].Value.ToString() + "\t");
                writer.WriteLine("");
            }
            writer.Close();
        }
        private void update()
        {
            DataGridViewRow update = contacts.Rows[selectedData];
            update.Cells[0].Value = viewName.Text;
            update.Cells[1].Value = viewNumber1.Text;
            update.Cells[2].Value = viewNumber2.Text;
            update.Cells[3].Value = viewNumber3.Text;

            MessageBox.Show("Contact updated!", "Success");

            view_clear();

            read_only_true();

            save_to_txt();
        }
        private void delete()
        {
            selectedData = contacts.CurrentCell.RowIndex;
            DialogResult dr = MessageBox.Show("Are you sure to delete?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                contacts.Rows.RemoveAt(selectedData);
            }

            view_clear();

            save_to_txt();
        }
        private void Search()
        {
            DataView dataView = table.DefaultView;
            dataView.RowFilter = "Name LIKE'" + search.Text + "%' OR Number1 LIKE '" + search.Text + "%' OR Number2  LIKE'" + search.Text + "%'OR Number3 LIKE '" + search.Text + "%'";
            contacts.DataSource = dataView;

            save_to_txt();
        }
        private void add_clear()
        {
            addName.Clear();
            addNumber1.Clear();
            addNumber2.Clear();
            addNumber3.Clear();
        }
        private void view_clear()
        {
            viewName.Clear();
            viewNumber1.Clear();
            viewNumber2.Clear();
            viewNumber3.Clear();
        }
        private void read_only_true()
        {
            viewName.ReadOnly = true;
            viewNumber1.ReadOnly = true;
            viewNumber2.ReadOnly = true;
            viewNumber3.ReadOnly = true;
        }
        private void read_only_false()
        {
            viewName.ReadOnly = false;
            viewNumber1.ReadOnly = false;
            viewNumber2.ReadOnly = false;
            viewNumber3.ReadOnly = false;
        }
        
    }
}
