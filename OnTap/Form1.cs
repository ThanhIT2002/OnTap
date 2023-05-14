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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void câu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cau2 c2 = new cau2();
            c2.ShowDialog();
            this.Hide();
        }

        private void câu2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cau2 c2 = new cau2();
            c2.ShowDialog();
            this.Hide();
        }

        private void câu2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            cau2 c2 = new cau2();
            c2.ShowDialog();
            this.Hide();
        }

        private void câu2ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            cau2 c2 = new cau2();
            c2.ShowDialog();
            this.Hide();
        }

        private void câu2ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Cau2_De5 c2 = new Cau2_De5();
            c2.ShowDialog();
            this.Hide();
        }

        private void câu2ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Cau2_De6 c2 = new Cau2_De6();
            c2.ShowDialog();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void câu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau3_De1 c3d1 = new Cau3_De1();
            c3d1.Show();
            this.Hide();
        }

        private void câu3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cau3_De2 c3d2 = new Cau3_De2();
            c3d2.Show();
            this.Hide();
        }

        private void câu3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
