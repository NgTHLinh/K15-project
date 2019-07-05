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
using System.Globalization;

namespace CRM
{
    public partial class TraPhong : Form
    {
        public static int a, b, c;
        string tx;
        string ID;
        string mm;
        string k;
        Home homee;
        Button b1;
        public TraPhong(string txt, Home h, Button b2)
        {
            homee = h;
            b1 = b2;
            tx = txt;
            InitializeComponent();
            
            label3.Text = tx;

            
        }
        
        private void TraPhong_Load(object sender, EventArgs e)
        {
            
            mm = "ConTrong";
            ThongTinKhachThueEntities table = new ThongTinKhachThueEntities();
            //string q, w;
            lb_contentCMND.Text = "0";
            lb_contentSDT.Text = "0";
            ID = string.Format("{0}", label3.Text.Substring(6));
            ThongTinKhachThueEntities c = new ThongTinKhachThueEntities();
            c.ID = Convert.ToInt32(ID);
            ThongTinKhachThueBUS ll = new ThongTinKhachThueBUS();
            DataTable dt = ll.Get(c);
            
            if (dt.Rows.Count > 0)
            {
                for (int p = 0; p < dt.Rows.Count; p++)
                {
                    table.ID = Convert.ToInt32(dt.Rows[p][0].ToString());
                    table.Ten = dt.Rows[p][1].ToString();
                    table.NgaySinh = dt.Rows[p][2].ToString();
                    table.GioiTinh = Convert.ToBoolean(dt.Rows[p][3].ToString());
                    table.CMND = Convert.ToInt32(dt.Rows[p][4].ToString());
                    table.NgayCap = dt.Rows[p][5].ToString();
                    table.NoiCap = dt.Rows[p][6].ToString();
                    table.NgayVao = dt.Rows[p][7].ToString();
                    table.Sdt = Convert.ToInt32(dt.Rows[p][8].ToString());

                    
                    lb_contentNguoiThue.Text = string.Format("{0}", dt.Rows[p][1].ToString());
                    lb_contentCMND.Text =string.Format("{0}", dt.Rows[p][4].ToString());
                    lb_contentSDT.Text = string.Format("{0}", dt.Rows[p][8].ToString());
                    lb_contentNgayVao.Text = string.Format("{0}", dt.Rows[p][7].ToString());
                }
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_TinhTien_Click(object sender, EventArgs e)
        {
            int a, b, c;

            if(txt_contentDien.Text == "")
            {
                MessageBox.Show("Xin nhặp số điện");
                txt_contentDien.Focus();
            }
            else
            {
                if (txt_contentNuoc.Text == "")
                {
                    MessageBox.Show("Xin nhặp số nước");
                    txt_contentNuoc.Focus();
                }
                else
                {
                    if (txt_contentInternet.Text == "")
                    {
                        MessageBox.Show("Xin nhặp số tháng dùng Internet");
                        txt_contentInternet.Focus();
                    }
                    else
                    {
                        a = Convert.ToInt32(txt_contentDien.Text);
                        b = Convert.ToInt32(txt_contentNuoc.Text);
                        c = Convert.ToInt32(txt_contentInternet.Text);

                        int ee;
                        ee = (a * 10000) + (b * 10000) + (c * 350000);
                        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                        lb_TongCong.Text = ee.ToString("#,###", cul.NumberFormat) + " VND";

                        btn_TraPhong.Enabled = true;
                    }
                }
            }
        }

        

        public void btn_TraPhong_Click(object sender, EventArgs e)
        {
            //string q, w, p;
            
            HoaDonEntities hd = new HoaDonEntities();
            hd.Phong = ID;
            hd.Ten = lb_contentNguoiThue.Text;
            hd.Sdt = lb_contentSDT.Text;
            hd.NgayVao = lb_contentNgayVao.Text;
            hd.NgayTra =Convert.ToString(System.DateTime.Today.ToString());
            hd.SoDien = txt_contentDien.Text;
            hd.SoNuoc = txt_contentNuoc.Text;
            hd.SoInternet = txt_contentInternet.Text;
            hd.TongCong =lb_TongCong.Text;
            HoaDonBUS hdbus = new HoaDonBUS();
            DataTable dtt = hdbus.ThemHDBUS(hd);

            PhongEntities ee = new PhongEntities();
            ThongTinKhachThueEntities c = new ThongTinKhachThueEntities();
            c.ID = Convert.ToInt32(ID);
            c.Ten = null;
            c.NgaySinh = null;
            //w = "";
            c.GioiTinh = Convert.ToBoolean(null);
            //q = "";
            c.CMND = Convert.ToInt32(null);
            //c.CMND = Convert.ToInt32(lb_contentCMND.Text);
            c.NgayCap = "";
            c.NoiCap = "";
            c.NgayVao = "";
            //p = "";
            c.Sdt = Convert.ToInt32(null);
            //c.PhongId = Convert.ToInt32("");

            ee.HienTrang = mm;
            ee.Id = Convert.ToInt32(ID);
            ThongTinKhachThueBUS cbus = new ThongTinKhachThueBUS();
            DataTable dt = cbus.GetTKBUS(c);
            PhongBUS t = new PhongBUS();
            DataTable tt = t.GetUpdate(ee);
            MessageBox.Show("Trả "+label3.Text+" thành công.");
            homee.doimauu(b1);
            Close();

        }
    }
}
