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
    public partial class Form1 : Form
    {
        public String stNo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            stNo = tb1.Text;
            
            if (stNo!="" && stNo!=" ")
            {
                Form2 form2 = new Form2();
                form2.stNop = tb1.Text;
                form2.Show();
            }
            else
            {
                MessageBox.Show("Student Number Can't be empty!", "Error!");
            }
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
