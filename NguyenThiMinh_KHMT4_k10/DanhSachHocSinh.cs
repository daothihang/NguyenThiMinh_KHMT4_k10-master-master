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

            dgvDanhSachHocSinh.DataSource = lopBUL.LayDsLop();
        }

        private void dgvDanhSachHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTenLop.Text == txtTenLop.Text)
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select  Lop.TenLop,HoSoHocSinh.MaHocSinh,HoSoHocSinh.HoTen,HoSoHocSinh.GioiTinh,HoSoHocSinh.DiaChi,HoSoHocSinh.HoTenBoMe,HoSoHocSinh.SoDienThoai from Lop inner join HoSoHocSinh on Lop.MaLop=HoSoHocSinh.MaLop where TenLop like'" + txtTenLop.Text + "%' ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDanhSachHocSinh.DataSource = dt;
            }
            else
                dgvDanhSachHocSinh.DataSource = lopBUL.LayDsLop();
            conn.Close();
        }
    }
}
