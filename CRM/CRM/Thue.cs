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
        string tx;
        public Thue()
        {
            InitializeComponent();

        }

        public Thue(string txt) : this()
        {
            tx = txt;
            label3.Text = tx;
        }

        private void Thue_Load(object sender, EventArgs e)
        {
            //label3.Text = tx;
            //DataTable name = new DataTable();
            //name = phong.GetTenPhong();
            //for (int i = 0; i < name.Rows.Count; i++)
            //{
            //    label3.Text = string.Format("Phòng {0}", name.Rows[i][0].ToString());
            //}
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
            

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
