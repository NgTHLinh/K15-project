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
        string ID;
        string mm;
        public Thue(string txt)
        {
            tx = txt;
            InitializeComponent();
            label3.Text = tx;
        }

       

        private void Thue_Load(object sender, EventArgs e)
        {
            mm = "Co Nguoi";
            if (label3.Text.Length > 5)
                ID = string.Format("{0}", label3.Text.Substring(6));
            
            
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
            LichSuEntities d = new LichSuEntities();
            PhongEntities ee = new PhongEntities();
            c.Ten = textBox1.Text;
            c.NgaySinh = dateTimePicker1.Text;
            if (checkBox1.Checked == true)
            {
                c.GioiTinh = true;
            }
            else
                c.GioiTinh = false;
            if (checkBox2.Checked == true)
            {
                c.GioiTinh = false;
            }
            else
                c.GioiTinh = true;

            c.CMND = Convert.ToInt32(textBox11.Text);
            c.NgayCap = dateTimePicker4.Text;
            c.NoiCap = comboBox3.Text;
            c.NgayVao = dateTimePicker5.Text;
            c.Sdt = Convert.ToInt32(textBox10.Text);
            c.ID = Convert.ToInt32(ID);

            d.Ten = textBox1.Text;
            d.NgaySinh = dateTimePicker1.Text;
            if (checkBox1.Checked == true)
            {
                d.GioiTinh = true;
            }
            else
                d.GioiTinh = false;
            if (checkBox2.Checked == true)
            {
                d.GioiTinh = false;
            }
            else
                d.GioiTinh = true;

            d.CMND = Convert.ToInt32(textBox11.Text);
            d.NgayCap = dateTimePicker4.Text;
            d.NoiCap = comboBox3.Text;
            d.NgayVao = dateTimePicker5.Text;
            d.Sdt = Convert.ToInt32(textBox10.Text);
            d.ID = Convert.ToInt32(ID);

            ee.HienTrang = mm;
            ee.Id = Convert.ToInt32(ID);
            ThongTinKhachThueBUS cbus = new ThongTinKhachThueBUS();
            DataTable dt = cbus.GetTKBUS(c);
            LichSuBUS a = new LichSuBUS();
            DataTable s = a.ThemLSBUS(d);
            PhongBUS t = new PhongBUS();
            DataTable tt = t.GetUpdate(ee);

            MessageBox.Show("Thuê "+label3.Text+" thành công.");
            //((Button)sender).BackColor = Color.Red;
            
            Close();

        }
    }
}
