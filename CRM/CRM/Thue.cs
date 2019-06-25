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
        public Thue(string txt)
        {
            tx = txt;
            InitializeComponent();
            label3.Text = tx;
        }

       

        private void Thue_Load(object sender, EventArgs e)
        {
           
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

        private void button1_Click(object sender, EventArgs e)
        {
            ThongTinKhachThueEntities c = new ThongTinKhachThueEntities();
            c.Ten = textBox1.Text;
            c.NgaySinh = dateTimePicker1.Text;
            if (ck_NamKhachThue.Checked == true)
            {
                c.GioiTinh = true;
            }
            else
                c.GioiTinh = false;
            if (ck_NuKhachThue.Checked == true)
            {
                c.GioiTinh = false;
            }
            else
                c.GioiTinh = true;

            c.CMND = Convert.ToInt32(txt_CmndNgThue.Text);
            c.Sdt = Convert.ToInt32(txt_SdtNgThue.Text);
        }
    }
}
