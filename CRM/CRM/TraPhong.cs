using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRM
{
    public partial class TraPhong : Form
    {
        public static int a, b, c;
        public TraPhong()
        {
            InitializeComponent();
        }

        private void TraPhong_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btn_TraPhong_Click(object sender, EventArgs e)
        {
            //a = txt_contentDien.Text;
        }
    }
}
