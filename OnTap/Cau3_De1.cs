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
    public partial class Cau3_De1 : Form
    {
        public Cau3_De1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "insert into tbTeamLeader values (N'"
                + txtTen.Text + "',"
                + txtNamSinh.Text + ","
                + txtMucLuong.Text + ","
                + txtTienTK.Text + ","
                + txtLuongTN.Text + ")";
            Connect.AddUpdateDelete(sql);
           show();
            reset();
        }
        public void show()
        {
            dgvData.DataSource = Connect.GetTable("select * from tbTeamLeader");

            dgvData.Columns[0].HeaderText = "Tên";
            dgvData.Columns[1].HeaderText = "Năm sinh";
            dgvData.Columns[2].HeaderText = "Mức lương trong một tháng";
            dgvData.Columns[3].HeaderText = "Tiền trong tài khoản";
            dgvData.Columns[4].HeaderText = "Lương trách nhiệm";

            dgvData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvData.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }
        public void reset()
        {
            txtTen.Text = "";
            txtNamSinh.Text = "";
            txtTienTK.Text = "";
            txtLuongTN.Text = "";
            txtMucLuong.Text = "";
        }
       
        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Cau3_De1_Load(object sender, EventArgs e)
        {
            show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            String sql = "update tbTeamLeader set NamSinh ="
                + txtNamSinh.Text + ",MucLuongMotThang ="
                + txtMucLuong.Text + ",TienTrongTaiKhoan ="
                + txtTienTK.Text + ",LuongTrachNhiem ="
                + txtLuongTN.Text + "where Ten = N'"
                + txtTen.Text + "'";
            Connect.AddUpdateDelete(sql);
            show();
            reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String sql = "delete from tbTeamLeader where Ten =N'" + txtTen.Text + "'";
            Connect.AddUpdateDelete(sql);
            show();
            reset();
        }

        private void dgvData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.CurrentRow != null)
            {
                txtTen.Text = dgvData.CurrentRow.Cells[0].Value.ToString();
                txtNamSinh.Text = dgvData.CurrentRow.Cells[1].Value.ToString();
                txtMucLuong.Text = dgvData.CurrentRow.Cells[2].Value.ToString();
                txtTienTK.Text = dgvData.CurrentRow.Cells[3].Value.ToString();
                txtLuongTN.Text = dgvData.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void Cau3_De1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
