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
    public partial class Cau3_De2 : Form
    {
        public Cau3_De2()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sqlThem = "insert into qlCauThu values(N'"
                +txtTen.Text+"',"+txtTuoi.Text+","+txtSoBanThang.Text
                +","+txtMucLuong.Text+")";
            Connect.AddUpdateDelete(sqlThem);
            show();
        }

        private void Cau3_De2_Load(object sender, EventArgs e)
        {
            show();
         }
        private void show()
        {
            dgvData.DataSource = Connect.GetTable("select * from qlCauThu");

            dgvData.Columns[0].HeaderText = "Họ Tên";
            dgvData.Columns[1].HeaderText = "Tuổi";
            dgvData.Columns[2].HeaderText = "Số bàn thắng đã ghi";
            dgvData.Columns[3].HeaderText = "Mức lương";

            dgvData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        private void dgvData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.CurrentRow != null)
            {
                txtTen.Text = dgvData.CurrentRow.Cells[0].Value.ToString();
                txtTuoi.Text = dgvData.CurrentRow.Cells[1].Value.ToString();
                txtSoBanThang.Text = dgvData.CurrentRow.Cells[2].Value.ToString();
                txtMucLuong.Text = dgvData.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void Cau3_De2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlSua = "update qlCauThu set tuoi="+txtTuoi.Text
                +",sobanthang="+txtSoBanThang.Text
                +",mucluong="+txtMucLuong.Text+"where hoten=N'"
                +txtTen.Text+"'";
            Connect.AddUpdateDelete(sqlSua);
            show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sqlXoa = "delete from qlCauThu where hoten=N'" +
                txtTen.Text + "'";
            Connect.AddUpdateDelete(sqlXoa);
            show();
        }
    }
}
