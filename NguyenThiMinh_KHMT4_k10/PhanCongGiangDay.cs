﻿using System;
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
            cbgv.SelectedIndex = -1;
            cbgv.ValueMember = "MaCanBoGiaoVien";


            cblop.DataSource = mylop.LayDsLop();
            cblop.DisplayMember = "TenLop";
            cblop.SelectedIndex = -1;
            cblop.ValueMember = "MaLop";

            cbmon.DataSource = mymon.LayDanhSachMonHoc();
            cbmon.DisplayMember = "TenMon";
            cbmon.SelectedIndex=-1;
            cbmon.ValueMember = "MaMon";

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAdmin ad = new FormAdmin();
            ad.Show();
        }

        private void btnphancong_Click(object sender, EventArgs e)
        {
            myPhanCong.phanCong((String)cblop.SelectedValue, (String)cbmon.SelectedValue, (String)cbgv.SelectedValue, datephancong.Text);
            hienthi();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            if (cblop.SelectedIndex != -1)
            {
                DataTable dt = myPhanCong.XemDsPhanCongTheoLop(cblop.Text);
                dgv.DataSource = dt;
            }
            else if (cbmon.SelectedIndex != -1)
            {

                DataTable dt1 = myPhanCong.XemDsPhanCongTheoMon(cbmon.Text);
                dgv.DataSource = dt1;
            }
            else if (cbgv.SelectedIndex != -1)
            {
                DataTable dt2 = myPhanCong.XemDsPhanCongTheoGv(cbgv.Text);
                dgv.DataSource = dt2;
            }



        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            PhanCongGiangDayDTO dto = new PhanCongGiangDayDTO((String)cblop.SelectedValue, (String)cbmon.SelectedValue, (String)cbgv.SelectedValue, datephancong.Text);
            myPhanCong.sua(dto);
            hienthi();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doi_MK doimk = new Doi_MK();
            doimk.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeThong ht = new HeThong();
            ht.Show();
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemHoSoHocSinh hs = new XemHoSoHocSinh();
            hs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbgv.SelectedIndex = -1;
            cbmon.SelectedIndex = -1;
            cblop.SelectedIndex = -1;
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            HoSoHocSinh hoSoHocSinh = new HoSoHocSinh();
            hoSoHocSinh.Show();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            QuanLyMonHoc quanLyMonHoc = new QuanLyMonHoc();
            quanLyMonHoc.Show();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop();
            lop.Show();
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            CanBoGiaoVien canBoGiaoVien = new CanBoGiaoVien();
            canBoGiaoVien.Show();
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {

            DanhSachHocSinh danhSachHocSinh = new DanhSachHocSinh();
            danhSachHocSinh.Show();
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            DanhSachGiaoVien danhSachGiaoVien = new DanhSachGiaoVien();
            danhSachGiaoVien.Show();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemCanBoGV cbgv = new XemCanBoGV();
            cbgv.Show();
        }
    }
}
