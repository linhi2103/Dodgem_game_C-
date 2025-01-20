using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_dodgem
{
    public partial class Form_TrangChu : Form
    {
        public Form_TrangChu()
        {
            InitializeComponent();
        }

        private void but_Start_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.FormClosed += (s, args) => this.Close(); // Đóng form "Trang chủ" khi Form1 đóng
            form1.Show(); // Mở Form1
            this.Hide(); // Ẩn form "Trang chủ" mà không đóng
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
