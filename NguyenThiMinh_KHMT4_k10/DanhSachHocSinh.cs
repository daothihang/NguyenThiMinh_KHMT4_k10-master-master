using BUL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThiMinh_KHMT4_k10
{
    public partial class DanhSachHocSinh : Form
    {
        public DanhSachHocSinh()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings
            ["KETNOIQLHS"].ToString());
        LopBUL lopBUL = new LopBUL();
        private void DanhSachHocSinh_Load(object sender, EventArgs e)
        {
            conn.Open();
            string sqlSelect = "select  Lop.TenLop,HoSoHocSinh.MaHocSinh,HoSoHocSinh.HoTen,HoSoHocSinh.GioiTinh,HoSoHocSinh.DiaChi,HoSoHocSinh.HoTenBoMe,HoSoHocSinh.SoDienThoai from Lop inner join HoSoHocSinh on Lop.MaLop=HoSoHocSinh.MaLop";
            SqlCommand cm = new SqlCommand(sqlSelect, conn);
            DataTable dt = new DataTable();
            SqlDataReader dr = cm.ExecuteReader();
            dt.Load(dr);
            dgvDanhSachHocSinh.DataSource = dt;
        }

        private void dgvDanhSachHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {

        }
    }
}
