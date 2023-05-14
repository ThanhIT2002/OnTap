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
using static System.Net.Mime.MediaTypeNames;

namespace OnTap
{
    public partial class cau2 : Form
    {
        public cau2()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        
        private void menuOpen_Click(object sender, EventArgs e)
        {
            ofd.Filter = ("text files (*.txt)|*.txt");
            DialogResult dr = ofd.ShowDialog();
            if(dr == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                rtbText.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(ofd.FileName);
            sw.WriteLine(rtbText.Text);
            sw.Close();
        }

        private void menuClear_Click(object sender, EventArgs e)
        {
            rtbText.Text = "";
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmsFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            rtbText.Font = fd.Font;
        }

        private void cmsColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            rtbText.ForeColor = cd.Color;
        }

        private void cau2_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
