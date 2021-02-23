using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassPractice1
{
    public partial class Form3 : Form
    {
        ListView listview;
        public Form3(ListView lv)
        {
            InitializeComponent();
            this.listview = lv;
        }
        private void lbGrade_Click(object sender, EventArgs e)
        {

        }

        private void addbtn1_Click(object sender, EventArgs e)
        {
            var Year1 = listview.Groups["Year 1"];
            var Year2 = listview.Groups["Year 2"];
            var Year3 = listview.Groups["Year 3"];
            var Year4 = listview.Groups["Year 4"];
            ListViewItem item = new ListViewItem(CourseCode.Text);
            item.SubItems.Add(Credit.Text);
            item.SubItems.Add(Grade.Text);

            String year;
            year = cb.Text;
            if (year== "Year-1")
            {
                item.Group = Year1;
                listview.Items.Add(item);
            }
            else if (year == "Year-2")
            {
                item.Group = Year2;
                listview.Items.Add(item);
            }
            else if (year == "Year-3")
            {
                item.Group = Year3;
                listview.Items.Add(item);
            }
            else if (year == "Year-4")
            {
                item.Group = Year4;
                listview.Items.Add(item);
            }

        }
    }
}
