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
    public partial class XemDSMonHoc : Form
    {
        public XemDSMonHoc()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings
             ["KETNOIQLHS"].ToString());
        MonHocBUL myMonHoc = new MonHocBUL();
        private void XemDSMonHoc_Load(object sender, EventArgs e)
        {
            cbTenMon.DataSource = myMonHoc.LayDanhSachMonHoc();
            cbTenMon.DisplayMember = "TenMon";
            cbTenMon.ValueMember = "TenMon";
            dgvDSMonHoc.DataSource = myMonHoc.LayDanhSachMonHoc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text == txtMaMon.Text)
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select  MaMon,TenMon,SoTiet from MonHoc where  MaMon like '" + txtMaMon.Text + "%' ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDSMonHoc.DataSource = dt;
            }
            else
                dgvDSMonHoc.DataSource = myMonHoc.LayDanhSachMonHoc();
            conn.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbTenMon.Text == (string)cbTenMon.SelectedValue)
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select  MaMon,TenMon,SoTiet from MonHoc where  TenMon like '" + cbTenMon.Text + "%' ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDSMonHoc.DataSource = dt;
            }
            else
                dgvDSMonHoc.DataSource = myMonHoc.LayDanhSachMonHoc();
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
