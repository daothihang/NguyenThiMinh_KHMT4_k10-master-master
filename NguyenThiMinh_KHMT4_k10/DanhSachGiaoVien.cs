using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using BUL;
using DTO;

namespace NguyenThiMinh_KHMT4_k10
{
    public partial class DanhSachGiaoVien  : Form
    {
        public DanhSachGiaoVien()
        {
            InitializeComponent();
        }
        LopBUL lop = new LopBUL();
        PhanCongGiangDayBUL pcgd = new PhanCongGiangDayBUL();
        private void _1_Load(object sender, EventArgs e)
        {
            cboTenLop.DataSource = lop.LayDsLop();
            cboTenLop.DisplayMember = "TenLop";
            cboTenLop.ValueMember = "TenLop";
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings
           ["KETNOIQLHS"].ToString());

            if (cboTenLop.Text == (string)cboTenLop.SelectedValue)
            {

                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select CanBoGiaoVien.MaCanBoGiaoVien, CanBoGiaoVien.HoTen, CanBoGiaoVien.SoDienthoai, MonHoc.TenMon, PhanCongGiangDay.NgayPhanCong from PhanCongGiangDay inner join CanBoGiaoVien on PhanCongGiangDay.MaCanBoGiaoVien= CanBoGiaoVien.MaCanBoGiaoVien inner join MonHoc on PhanCongGiangDay.MaMon= MonHoc.MaMon inner join Lop on PhanCongGiangDay.MaLop= Lop.MaLop where TenLop like'" + cboTenLop.Text + "%' ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHT.DataSource = dt;
            }
            else if (cboTenLop.Text == "")
            {
                dgvHT.DataSource = pcgd.LayDanhSachPhanCongGiangDay();
            }
            conn.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog.Document = PrintDocument;
            PrintPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.dgvHT.Width, this.dgvHT.Height);
            dgvHT.DrawToBitmap(bmp, new Rectangle(0, 0, dgvHT.Width, dgvHT.Height));
            e.Graphics.DrawImage(bmp, 10, 200);
            e.Graphics.DrawString("Danh sách học sinh", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, new Point(230, 100));

        }
    }
}


      


    


      




 