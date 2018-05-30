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
using DTO;
namespace NguyenThiMinh_KHMT4_k10
{
    public partial class PhanCongGiangDay : Form
    {
        public PhanCongGiangDay()
        {
            InitializeComponent();
        }

        PhanCongGiangDayBUL myPhanCong = new PhanCongGiangDayBUL();
        LopBUL mylop = new LopBUL();
        CanBoGiaoVienBUL mycbgv = new CanBoGiaoVienBUL();
        MonHocBUL mymon = new MonHocBUL();

        private void PhanCongGiangDay_Load(object sender, EventArgs e)
        {
            hienthi();

           

        }

       
        public void hienthi()
        {
            dgv.DataSource = myPhanCong.LayDanhSachPhanCongGiangDay();
            cbgv.DataSource = mycbgv.LayDsCanBo();
            cbgv.DisplayMember = "HoTen";
            cbgv.ValueMember = "MaCanBoGiaoVien";


            cblop.DataSource = mylop.LayDsLop();
            cblop.DisplayMember = "TenLop";
            cblop.ValueMember = "MaLop";

            cbmon.DataSource = mymon.LayDanhSachMonHoc();
            cbmon.DisplayMember = "TenMon";
            cbmon.ValueMember = "MaMon";

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

        }

        private void btnphancong_Click(object sender, EventArgs e)
        {
            myPhanCong.phanCong(cblop.Text, cbmon.Text, cbgv.Text, datephancong.Text);
            hienthi();
        }
    }
}
