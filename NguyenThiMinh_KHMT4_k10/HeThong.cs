﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThiMinh_KHMT4_k10
{
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangnhap dn = new Dangnhap();
            dn.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public int i = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lb1.Left += i;
            if (lb1.Left >= this.Width - lb1.Width-420||lb1.Left <= 0+48)
               i = -i;

        }

        private void HeThong_Load(object sender, EventArgs e)
        {
           // timer1.Start();
        }

        

       

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            Dangnhap dn = new Dangnhap();
            dn.Show();
        }

        private void toolStripMenuItem6_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            HuongDan huongDan = new HuongDan();
            huongDan.Show();
        }
    }
}
