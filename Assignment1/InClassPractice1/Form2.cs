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
    public partial class Form2 : Form
    {
        public String stNop,grade;
        public Form2()
        {
            InitializeComponent();
        }
        private void lb3_Click(object sender, EventArgs e)
        {

        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(lv);
            form3.Show();
        }
        private void Calculate_Click(object sender, EventArgs e)
        {
            /*
              gpa should be calculate here
            */
            String gpa = "Your GPA = 2.54";
            MessageBox.Show(gpa,stNop);
            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            var m = qr.CreateQrCode(gpa, QRCoder.QRCodeGenerator.ECCLevel.M);
            var code = new QRCoder.QRCode(m);
            pic.Image = code.GetGraphic(100);
        }

        private void lbStNo_Click(object sender, EventArgs e)
        {
            lbStNo.Text = stNop;
        }
    }
}
