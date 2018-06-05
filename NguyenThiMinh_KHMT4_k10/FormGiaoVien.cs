using System;
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
    public partial class FormGiaoVien : Form
    {
        public FormGiaoVien(String tengv)
        {
            InitializeComponent();
            label1.Text = tengv;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
