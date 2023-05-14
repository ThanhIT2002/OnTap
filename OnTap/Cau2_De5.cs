using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTap
{
    public partial class Cau2_De5 : Form
    {
        public Cau2_De5()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);
            float c = float.Parse(txtC.Text);
            float denta = (float)(b * b - 4 * a * c);
            float x = (float)(-b / (2 * a));
            float x1 = (float)((-b + Math.Sqrt(denta)) / 2 * a);
            float x2 = (float)((-b - Math.Sqrt(denta)) / 2 * a);
            if (denta < 0)
            {
                lblKetQua.Text = "Phương trình vô nghiệm";
            }
            else if (denta == 0)
            {
                lblKetQua.Text = "Phương trình có nghiệm là " + x + "";
            }
            else
            {
                lblKetQua.Text = "Phương trình có nghiệm là x1 = " + x1 + " x2= " + x2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
