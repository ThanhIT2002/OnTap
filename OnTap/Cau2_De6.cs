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
    public partial class Cau2_De6 : Form
    {
        public Cau2_De6()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);
            float c = float.Parse(txtC.Text);
            float d = float.Parse(txtD.Text);
            float n = float.Parse(txtN.Text);
            float m = float.Parse(txtM.Text);
            float temp = (float)((a * d) - (c * b));
            float tempX = (float)((m * d) - (n * b));
            float tempY = (float)((a * n) - (c * m));
            float X = (float)(tempX / temp);
            float Y = (float)(tempY / temp);
            if (temp != 0)
            {
                lblKetQua.Text = "Kết quả của hệ phương trình là X= " + X + ", Y= " + Y;
            }
            else
            {
                if (tempX == tempY)
                {
                    lblKetQua.Text = "Hệ phương trình vô số nghiệm";
                }
                else
                {
                    lblKetQua.Text = "Hệ phương trình vô nghiệm";
                }
            }
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            txtN.Text = "";
            txtM.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
