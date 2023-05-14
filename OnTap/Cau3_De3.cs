using Microsoft.SqlServer.Server;
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
    public partial class Cau3_De3 : Form
    {
        private static int p;
        private static DataTable dt;
        public Cau3_De3()
        {
            InitializeComponent();
        }
        public void show()
        {
            btnUpdate.Enabled = false;
            dt = Connect.GetTable("select * from qlCauTh");
            txtMaCauThu.Text = dt.Rows[p][0].ToString();
            txtHoTen.Text = dt.Rows[p][1].ToString();
            txtNgaySinh.Text = dt.Rows[p][2].ToString();
            txtQueQuan.Text = dt.Rows[p][3].ToString();
        }
        private void Cau3_De3_Load(object sender, EventArgs e)
        {
            dt = Connect.GetTable("select * from qlCauTh");
            p = 0;
            show();
            lblTieuDe.Text = "Người thứ " + (p + 1);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            p = 0;
            show();
            lblTieuDe.Text = "Người thứ " + (p + 1);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (p > 0)
            {
                p--;
                show();
                lblTieuDe.Text = "Người thứ " + (p + 1);
            }
            else
            {
                p = dt.Rows.Count - 1;
                show();
                lblTieuDe.Text = "Người thứ " + (p + 1);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(p<dt.Rows.Count-1)
            {
                p++;
                show();
                lblTieuDe.Text = "Người thứ " + (p + 1);
            }
            else
            {
                p = 0;
                show();
                lblTieuDe.Text = "Người thứ " + (p + 1);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            p = dt.Rows.Count - 1;
            show();
            lblTieuDe.Text = "Người thứ " + (p + 1);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ngaysinh = txtNgaySinh.Value.ToString("yyyy-MM-dd");
            string sql = "update qlCauth set hoten =N'"
                +txtHoTen.Text+"',ngaysinh='"
                +ngaysinh+"',quequan=N'"
                +txtQueQuan.Text+"' where mact=N'"
                +txtMaCauThu.Text+"'";
            Connect.AddUpdateDelete(sql);
            show();
            lblTieuDe.Text = "Người thứ " + (p + 1);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Cau3_De3_Them cau3_De3_Them = new Cau3_De3_Them();
            cau3_De3_Them.ShowDialog();
            this.Hide();
        }

        private void Cau3_De3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from qlCauth where mact=N'"
                + txtMaCauThu.Text + "'";
            Connect.AddUpdateDelete(sql);
            p = 0;
            show();
            lblTieuDe.Text = "Người thứ " + (p + 1);
        }

        private void txtMaCauThu_MouseClick(object sender, MouseEventArgs e)
        {
            btnUpdate.Enabled = true;
        }

        private void txtHoTen_MouseClick(object sender, MouseEventArgs e)
        {
            btnUpdate.Enabled = true;
        }

        private void txtNgaySinh_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }

        private void txtQueQuan_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }
    }
}
