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
    public partial class Cau3_De3_Them : Form
    {
        public Cau3_De3_Them()
        {
            InitializeComponent();
        }
        private void AddCmb()
        {
            cmbQueQuan.Items.Add("Hà Nội");
            cmbQueQuan.Items.Add("Thái Bình");
            cmbQueQuan.Items.Add("Bắc Ninh");
            cmbQueQuan.Items.Add("Lạng Sơn");
            cmbQueQuan.Items.Add("Phú Thọ");
            cmbQueQuan.Items.Add("Hà Tĩnh");
            cmbQueQuan.Items.Add("Bắc Ninh");
        }
        private void Cau3_De3_Them_Load(object sender, EventArgs e)
        {
           AddCmb();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "insert into qlCauth values (N'"
                +txtMaCauThu.Text+"',N'"
                +txtHoTen.Text+"','"
                +txtNgaySinh.Value.ToString("yyyy-MM-dd")+"',N'"
                +cmbQueQuan.Text+"')";
            Connect.AddUpdateDelete(sql);
 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtMaCauThu.Text = "";
            txtNgaySinh.Text = "";
            cmbQueQuan.Text = "";
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Cau3_De3 c3d3 = new Cau3_De3();
            c3d3.Show();
            this.Close();
        }
    }
}
