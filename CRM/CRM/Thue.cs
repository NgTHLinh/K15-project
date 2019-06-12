using BUS;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRM
{
    public partial class Thue : Form
    {
        TangBUS tang = new TangBUS();
        PhongBUS phong = new PhongBUS();
        public Thue()
        {
           


            InitializeComponent();
        }

        private void Thue_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Chỉ dùng số");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void label3_Paint(object sender, PaintEventArgs e)
        {
            DataTable dtphong = new DataTable();

            dtphong = phong.GetTenPhong();

            label3.Text = "Phòng "+ dtphong.Rows[0][0].ToString();
        }
    }
}
