using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using System.Data.SqlClient;
using System.Configuration;

namespace NguyenThiMinh_KHMT4_k10
{
    public partial class XemCanBoGV : Form
    {
        public XemCanBoGV()
        {
            InitializeComponent();
        }
        CanBoGiaoVienBUL CanBoGiaoVienBUL = new CanBoGiaoVienBUL();
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cboMCBGV.Text == (string)cboMCBGV.SelectedValue)
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings
              ["KETNOIQLHS"].ToString());
                SqlDataAdapter da = new SqlDataAdapter("select  MaCanBoGiaoVien, HoTen ,DiaChi, SoDienThoai, TaiKhoan, MatKhau, LoaiTaiKhoan from CanBoGiaoVien where MaCanBoGiaoVien like '" + cboMCBGV.Text + "%' ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHT.DataSource = dt;
            }
            else
                dgvHT.DataSource = CanBoGiaoVienBUL.LayDsCanBo();

        }

        private void XemCanBoGV_Load(object sender, EventArgs e)
        {
            cboMCBGV.DataSource = CanBoGiaoVienBUL.LayDsCanBo();
            cboMCBGV.DisplayMember = "MaCanBoGiaoVien";
            cboMCBGV.ValueMember = "MaCanBoGiaoVien";
        }
    }
    }

