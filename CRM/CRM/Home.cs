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
    
    public partial class Home : Form
    {
        //SqlConnection con = new SqlConnection();
        private Point _imageLocation = new Point(22, 0);
        private Point _imageHitArea = new Point(13, 2);
        Image CloseImage;

        TaiKhoanEntities userlogin = new TaiKhoanEntities();
        QuanLyNhanVienEntities addlogin = new QuanLyNhanVienEntities();
        ThongTinKhachThueEntities table = new ThongTinKhachThueEntities();
        ThanhToanEntities thanhtoan = new ThanhToanEntities();
        LichSuEntities Lichsu = new LichSuEntities();
        PhongEntities room = new PhongEntities();
        TangBUS tang = new TangBUS();
        ThongTinNhanVienBUS ttnv = new ThongTinNhanVienBUS();
        QuanLyNhanVienBUS qlnv = new QuanLyNhanVienBUS();
        ThongTinKhachThueBUS ttkt = new ThongTinKhachThueBUS();

        string ten;
        int SoDong;

        public Home()
        {
            //string conn = "Data Source=D:\\K15-project\\NCKH_KhoaLong.db";
            //SqlConnection con = new SqlConnection(conn);
            //con.ConnectionString = "Data Source=KRISHNA-PC\\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True";
            //con.ConnectionString = "Data Source=D:\\K15-project\\NCKH_KhoaLong.db";
            InitializeComponent();


            //btn_Logout.Hide();
            //btn_Home.Hide();
            //tabControl2.TabPages.Remove(TP_QlHoaDon);
            //tabControl2.TabPages.Remove(TP_QlNgThue);
            //tabControl2.TabPages.Remove(TP_QlNv);
            //tabControl2.TabPages.Remove(TP_QlPhong);

            //tabControl1.TabPages.Remove(TP_ThemNgThue);
            //tabControl1.TabPages.Remove(TP_ttphong);
            //tabControl1.TabPages.Remove(TP_tthd);
            //tabControl1.TabPages.Remove(TP_thue);
            //tabControl1.TabPages.Remove(TP_themnv);
            //tabControl1.TabPages.Remove(TP_home);
            //tabControl1.TabPages.Remove(TP_ttkhach);
            //tabControl1.TabPages.Remove(TP_ttnv);


        }



        private void Home_Load(object sender, EventArgs e)
        {
            {
                ThanhToanEntities t = new ThanhToanEntities();
                ThanhToanBUS tt = new ThanhToanBUS();
                DataTable dt = tt.GetThanhToanBUS(t);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        thanhtoan.Id = Convert.ToInt32(dt.Rows[i][0].ToString());
                        thanhtoan.SoDien =Convert.ToInt32(dt.Rows[i][1].ToString());
                        thanhtoan.SoNuoc =Convert.ToInt32(dt.Rows[i][2].ToString());
                        thanhtoan.NgayThanhToan = (dt.Rows[i][3].ToString());
                        thanhtoan.PhongId = Convert.ToInt32(dt.Rows[i][4].ToString());
                        thanhtoan.TienDichVu =Convert.ToInt32(dt.Rows[i][5].ToString());
                        

                        dataGridView1.Rows.Add(thanhtoan.Id,thanhtoan.SoDien,thanhtoan.SoNuoc,thanhtoan.NgayThanhToan,thanhtoan.PhongId,thanhtoan.TienDichVu);//, table.PhongId);
                    }
                }
            }
            {
                LichSuEntities t = new LichSuEntities();
                LichSuBUS ttktbus = new LichSuBUS();
                DataTable dt = ttktbus.GetBUS(t);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        table.ID = Convert.ToInt32(dt.Rows[i][0].ToString());
                        table.Ten = dt.Rows[i][1].ToString();
                        table.NgaySinh = dt.Rows[i][2].ToString();
                        table.GioiTinh = Convert.ToBoolean(dt.Rows[i][3].ToString());
                        table.CMND = Convert.ToInt32(dt.Rows[i][4].ToString());
                        table.NgayCap = dt.Rows[i][5].ToString();
                        table.NoiCap = dt.Rows[i][6].ToString();
                        table.NgayVao = dt.Rows[i][7].ToString();
                        table.Sdt = Convert.ToInt32(dt.Rows[i][8].ToString());

                        dataGridView2.Rows.Add(table.ID, table.Ten, table.NgaySinh, table.GioiTinh, table.CMND, table.NgayCap, table.NoiCap, table.NgayVao, table.Sdt);//, table.PhongId);
                    }
                }
            }
            {
                ThongTinNhanVienBUS nv = new ThongTinNhanVienBUS();
                DataTable dt = nv.GetTTNV();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        addlogin.MaNV = Convert.ToInt32(dt.Rows[i][0].ToString());
                        addlogin.Ten = dt.Rows[i][1].ToString();
                        addlogin.NgaySinh = dt.Rows[i][2].ToString();
                        addlogin.GioiTinh = Convert.ToBoolean(dt.Rows[i][3].ToString());
                        addlogin.ThuongTru = dt.Rows[i][4].ToString();
                        addlogin.TamTru = dt.Rows[i][5].ToString();
                        addlogin.Cmnd = Convert.ToInt32(dt.Rows[i][6].ToString());
                        addlogin.NgayCap = dt.Rows[i][7].ToString();
                        addlogin.NoiCap = dt.Rows[i][8].ToString();
                        addlogin.Email = dt.Rows[i][9].ToString();
                        addlogin.BoPhan = dt.Rows[i][10].ToString();
                        addlogin.NgayVao = dt.Rows[i][11].ToString();
                        addlogin.SDT = Convert.ToInt32(dt.Rows[i][12].ToString());

                        dataGridView3.Rows.Add(addlogin.MaNV, addlogin.Ten, addlogin.NgaySinh, addlogin.GioiTinh, addlogin.ThuongTru, addlogin.TamTru, addlogin.Cmnd, addlogin.NgayCap, addlogin.NoiCap, addlogin.Email, addlogin.BoPhan, addlogin.NgayVao, addlogin.SDT);

                    }
                }
            }
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.DrawItem += tabControl1_DrawItem;
            CloseImage = CRM.Properties.Resources.Closebutton;
            tabControl1.Padding = new Point(15, 3);
        }

        private void tabControl1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e) // Vẽ hình nút X lên cái tabpage trong tabcontrol1
        {
            try
            {
                Image img = new Bitmap(CloseImage);
                Rectangle r = e.Bounds;
                r = this.tabControl1.GetTabRect(e.Index);
                r.Offset(2, 2);
                string title = this.tabControl1.TabPages[e.Index].Text;
                Font f = this.Font;
                Brush titleBrush = new SolidBrush(Color.Black);
                e.Graphics.DrawString(title, f, titleBrush, new Point(r.X, r.Y));
                e.Graphics.DrawImage(img, new Point(r.X + this.tabControl1.GetTabRect(e.Index).Width - _imageLocation.X, _imageLocation.Y));
               
            }
            catch (Exception) { }
           

        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e) //Bắt sự kiện cho nút X
        {
            TabControl tc = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.tabControl1.GetTabRect(tc.SelectedIndex).Width - (_imageHitArea.X);
            Rectangle r = this.tabControl1.GetTabRect(tc.SelectedIndex);
            r.Offset(_tabWidth, _imageHitArea.Y);
            r.Width = 16;
            r.Height = 16;

            if (r.Contains(p))
            {
                if (MessageBox.Show("Bạn Có Muốn Tắt Tab Này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TabPage tabP = (TabPage)tc.TabPages[tc.SelectedIndex];
                    tc.TabPages.Remove(tabP);
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_NamKhachThue.Checked)
            {
                ck_NuKhachThue.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_NuKhachThue.Checked)
            {
                ck_NamKhachThue.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_NamNV.Checked)
            {
                ck_NuNV.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_NuNV.Checked)
            {
                ck_NamNV.Checked = false;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Chỉ dùng số");
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(TP_home))//tab already present
            {
                tabControl1.SelectTab(TP_home);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(TP_home); // add removed tab
                tabControl1.SelectTab(TP_home);    // select by name
            }

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(TP_ThemNgThue))//tab already present
            {
                tabControl1.SelectTab(TP_ThemNgThue);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(TP_ThemNgThue); // add removed tab
                tabControl1.SelectTab(TP_ThemNgThue);    // select by name
            }
        }

        private void btn_TTNV_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(TP_ttnv))//tab already present
            {
                tabControl1.SelectTab(TP_ttnv);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(TP_ttnv); // add removed tab
                tabControl1.SelectTab(TP_ttnv);    // select by name
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(TP_thue))//tab already present
            {
                tabControl1.SelectTab(TP_thue);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(TP_thue); // add removed tab
                tabControl1.SelectTab(TP_thue);    // select by name
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(TP_tthd))//tab already present
            {
                tabControl1.SelectTab(TP_tthd);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(TP_tthd); // add removed tab
                tabControl1.SelectTab(TP_tthd);    // select by name
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(TP_ttkhach))//tab already present
            {
                tabControl1.SelectTab(TP_ttkhach);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(TP_ttkhach); // add removed tab
                tabControl1.SelectTab(TP_ttkhach);    // select by name
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(TP_ttphong))//tab already present
            {
                tabControl1.SelectTab(TP_ttphong);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(TP_ttphong); // add removed tab
                tabControl1.SelectTab(TP_ttphong);    // select by name
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(TP_tk))//tab already present
            {
                tabControl1.SelectTab(TP_tk);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(TP_tk); // add removed tab
                tabControl1.SelectTab(TP_tk);    // select by name
            }


        }
        private void button86_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(TP_themnv))//tab already present
            {
                tabControl1.SelectTab(TP_themnv);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(TP_themnv); // add removed tab
                tabControl1.SelectTab(TP_themnv);    // select by name
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            int a = dataGridView3.CurrentCell.RowIndex;

            int s = Convert.ToInt32(dataGridView3.Rows[a].Cells[0].Value.ToString());
            ttnv.XoaNV(s);
            dataGridView3.Rows.RemoveAt(a);
            
            MessageBox.Show("Đã xóa" , "Thông Báo");

        }
        private void btn_XoaKT_Click(object sender, EventArgs e)
        {
            int a = dataGridView2.CurrentCell.RowIndex;
            int s = Convert.ToInt32(dataGridView2.Rows[a].Cells[0].Value.ToString());
            ttkt.XoaKTBUS(s);
            dataGridView2.Rows.RemoveAt(a);
            MessageBox.Show("Đã xóa", "Thông Báo");
        }



        private void btn_TraCuuKT_Click(object sender, EventArgs e)
        {
            LichSuEntities t = new LichSuEntities();



            dataGridView2.Rows.Clear();

            if (txt_TenKT_TT.Text == "")
            {
                t.ID = Convert.ToInt32(Txt_MaKhachHang_TT.Text);
                LichSuBUS a = new LichSuBUS();
                DataTable dt = a.GetmmBUS(t);
                if (dt.Rows.Count > 0)
                {
                    for (int p = 0; p<dt.Rows.Count;p++)
                    {
                    Lichsu.ID = Convert.ToInt32(dt.Rows[p][0].ToString());
                    Lichsu.Ten = dt.Rows[p][1].ToString();
                    Lichsu.NgaySinh = dt.Rows[p][2].ToString();
                    Lichsu.GioiTinh = Convert.ToBoolean(dt.Rows[p][3].ToString());
                    Lichsu.CMND = Convert.ToInt32(dt.Rows[p][4].ToString());
                    Lichsu.NgayCap = dt.Rows[p][5].ToString();
                    Lichsu.NoiCap = dt.Rows[p][6].ToString();
                    Lichsu.NgayVao = dt.Rows[p][7].ToString();
                    Lichsu.Sdt = Convert.ToInt32(dt.Rows[p][8].ToString());

                    dataGridView2.Rows.Add(Lichsu.ID, Lichsu.Ten, Lichsu.NgaySinh, Lichsu.GioiTinh, Lichsu.CMND, Lichsu.NgayCap, Lichsu.NoiCap, Lichsu.NgayVao, Lichsu.Sdt);
                    
                    }
                    SoDong = dt.Rows.Count;
                    MessageBox.Show("Tìm Thấy " + SoDong + " kết quả.", "Thông Báo");
                }
            }
            if (Txt_MaKhachHang_TT.Text == "")
            {
                t.Ten = txt_TenKT_TT.Text;
                LichSuBUS a = new LichSuBUS();
                DataTable dt = a.GetmmmBUS(t);
                if (dt.Rows.Count > 0)
                {
                    for (int p = 0; p < dt.Rows.Count; p++)
                    {
                        Lichsu.ID = Convert.ToInt32(dt.Rows[p][0].ToString());
                        Lichsu.Ten = dt.Rows[p][1].ToString();
                        Lichsu.NgaySinh = dt.Rows[p][2].ToString();
                        Lichsu.GioiTinh = Convert.ToBoolean(dt.Rows[p][3].ToString());
                        Lichsu.CMND = Convert.ToInt32(dt.Rows[p][4].ToString());
                        Lichsu.NgayCap = dt.Rows[p][5].ToString();
                        Lichsu.NoiCap = dt.Rows[p][6].ToString();
                        Lichsu.NgayVao = dt.Rows[p][7].ToString();
                        Lichsu.Sdt = Convert.ToInt32(dt.Rows[p][8].ToString());

                        dataGridView2.Rows.Add(Lichsu.ID, Lichsu.Ten, Lichsu.NgaySinh, Lichsu.GioiTinh, Lichsu.CMND, Lichsu.Sdt);
                        
                    }
                    SoDong = dt.Rows.Count;
                    MessageBox.Show("Tìm Thấy " + SoDong + " kết quả.", "Thông Báo");
                }
            }
            if (Txt_MaKhachHang_TT.Text != "" & txt_TenKT_TT.Text != "")
            {
                t.ID = Convert.ToInt32(Txt_MaKhachHang_TT.Text);
                t.Ten = txt_TenKT_TT.Text;
                LichSuBUS a = new LichSuBUS();
                DataTable dt = a.GetmBUS(t);
                if (dt.Rows.Count > 0)
                {
                    for (int p = 0; p < dt.Rows.Count; p++)
                    {
                        Lichsu.ID = Convert.ToInt32(dt.Rows[p][0].ToString());
                        Lichsu.Ten = dt.Rows[p][1].ToString();
                        Lichsu.NgaySinh = dt.Rows[p][2].ToString();
                        Lichsu.GioiTinh = Convert.ToBoolean(dt.Rows[p][3].ToString());
                        Lichsu.CMND = Convert.ToInt32(dt.Rows[p][4].ToString());
                        Lichsu.NgayCap = dt.Rows[p][5].ToString();
                        Lichsu.NoiCap = dt.Rows[p][6].ToString();
                        Lichsu.NgayVao = dt.Rows[p][7].ToString();
                        Lichsu.Sdt = Convert.ToInt32(dt.Rows[p][8].ToString());

                        dataGridView2.Rows.Add(Lichsu.ID, Lichsu.Ten, Lichsu.NgaySinh, Lichsu.GioiTinh, Lichsu.CMND, Lichsu.Sdt);
                        
                    }
                    SoDong = dt.Rows.Count;
                    MessageBox.Show("Tìm Thấy "+SoDong+" kết quả.","Thông Báo");
                }
            }
        }
        private void btn_TraCuuNV_Click(object sender, EventArgs e)
        {
            QuanLyNhanVienEntities nv = new QuanLyNhanVienEntities();

            nv.MaNV = Convert.ToInt32(txt_MaNV_TT.Text);

            TimKiemNhanVienBUS tim = new TimKiemNhanVienBUS();
            DataTable dt = tim.GetTKNV(nv);
            dataGridView3.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                addlogin.MaNV = Convert.ToInt32(dt.Rows[0][0].ToString());
                addlogin.Ten = dt.Rows[0][1].ToString();
                addlogin.NgaySinh = dt.Rows[0][2].ToString();
                addlogin.GioiTinh = Convert.ToBoolean(dt.Rows[0][3].ToString());
                addlogin.ThuongTru = dt.Rows[0][4].ToString();
                addlogin.TamTru = dt.Rows[0][5].ToString();
                addlogin.Cmnd = Convert.ToInt32(dt.Rows[0][6].ToString());
                addlogin.NgayCap = dt.Rows[0][7].ToString();
                addlogin.NoiCap = dt.Rows[0][8].ToString();
                addlogin.Email = dt.Rows[0][9].ToString();
                addlogin.BoPhan = dt.Rows[0][10].ToString();
                addlogin.NgayVao = dt.Rows[0][11].ToString();
                addlogin.SDT = Convert.ToInt32(dt.Rows[0][12].ToString());

                //foreach (var item in )
                //{
                //System.Data.DataTable dataTable = new System.Data.DataTable();
                dataGridView3.Rows.Add(addlogin.MaNV, addlogin.Ten, addlogin.NgaySinh, addlogin.GioiTinh, addlogin.ThuongTru, addlogin.TamTru, addlogin.Cmnd, addlogin.NgayCap, addlogin.NoiCap, addlogin.Email, addlogin.BoPhan, addlogin.NgayVao, addlogin.SDT);
                //dataGridView3.DataSource = dt;
                //}
                SoDong = dt.Rows.Count;
                MessageBox.Show("Tìm Thấy " + SoDong + " kết quả.", "Thông Báo");

            }
        }

        private void button16_Click(object sender, EventArgs e) // Đăng nhập và phân quyền !!!
        {

            TaiKhoanEntities log = new TaiKhoanEntities();

            log.Taikhoan = txt_TaiKhoan.Text;
            log.Matkhau = txt_MatKhau.Text;
            

            TaiKhoanBUS logbus = new TaiKhoanBUS();
            DataTable dt = logbus.GetTK(log);

            if (dt.Rows.Count > 0)
            {
                userlogin.Id = Convert.ToInt32(dt.Rows[0][0].ToString());
                userlogin.Taikhoan = dt.Rows[0][1].ToString();
                userlogin.Loai = dt.Rows[0][3].ToString();

                switch (userlogin.Loai)
                {
                    case "1":
                        MessageBox.Show("Welcome Admin " + userlogin.Taikhoan);
                        btn_Login.Hide();
                        btn_Logout.Show();
                        btn_Home.Show();


                        tabControl2.TabPages.Add(TP_QlNgThue);
                        tabControl2.TabPages.Add(TP_QlPhong);
                        tabControl2.TabPages.Add(TP_QlHoaDon);
                        tabControl2.TabPages.Add(TP_QlNv);


                        tabControl1.TabPages.Add(TP_home);
                        tabControl1.TabPages.Remove(TP_tk);
                        //this.Visible = false;
                        break;
                    case "2":
                        MessageBox.Show("Welcome NhanVien " + userlogin.Taikhoan);
                        btn_Home.Show();

                        tabControl1.TabPages.Remove(TP_tk);
                        tabControl1.TabPages.Add(TP_home);

                        tabControl2.TabPages.Add(TP_QlPhong);
                        tabControl2.TabPages.Add(TP_QlHoaDon);

                        btn_Login.Hide();
                        btn_Logout.Show();
                        //zzz.TabPages.Remove(tab2_p);
                        break;
                    case "3":
                        MessageBox.Show("Welcome KhachHang " + userlogin.Taikhoan);

                        btn_Login.Hide();
                        btn_Logout.Show();
                        break;


                }

                // if (userlogin.Loai == 3)//la nhan vien}
                //MessageBox.Show("Welcome to NoWhere !!");
            }
            else
                MessageBox.Show("Đăng nhập thất bại !!!");

        }

        private void button17_Click(object sender, EventArgs e)
        {

            Form a = new Home();

            this.Visible = false;
            a.ShowDialog();
            //btn_Login.Show();
        }
        public void doimau(Button bt)
        {
            bt.BackColor = Color.Red;
            
        }
        public void doimauu(Button bs)
        {
            bs.BackColor = DefaultBackColor;
        }

        private void bt_Click5(object sender, MouseEventArgs e)
        {
            string tn = ((Button)sender).Text;
            Button tnn = ((Button)sender);
            string tp = ((Button)sender).Text;
            Thue p = new Thue(tn,this,tnn);
            TraPhong pp = new TraPhong(tp,this,tnn);
            if (((Button)sender).BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Right)
                {
                    pp.ShowDialog();
                }
            }
            if (((Button)sender).BackColor == DefaultBackColor)
            {
                if (e.Button == MouseButtons.Left)
                {
                    p.ShowDialog();
                }
                
            }
        }

        private void bt_Click4(object sender, MouseEventArgs e)
        {
            string tn = ((Button)sender).Text;
            string tp = ((Button)sender).Text;
            Button tnn = ((Button)sender);
            Thue p = new Thue(tn,this,tnn);
            TraPhong pp = new TraPhong(tp,this,tnn);
            if (((Button)sender).BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Right)
                {
                    pp.ShowDialog();
                }
            }
            if (((Button)sender).BackColor == DefaultBackColor)
            {
                if (e.Button == MouseButtons.Left)
                {
                    p.ShowDialog();
                }
                
            }
        }

        private void bt_Click7(object sender, MouseEventArgs e)
        {
            string tn = ((Button)sender).Text;
            string tp = ((Button)sender).Text;
            Button tnn = ((Button)sender);
            Thue p = new Thue(tn,this,tnn);
            TraPhong pp = new TraPhong(tp,this,tnn);
            if (((Button)sender).BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Right)
                {
                    pp.ShowDialog();
                }
            }
            if (((Button)sender).BackColor == DefaultBackColor)
            {
                if (e.Button == MouseButtons.Left)
                {
                    p.ShowDialog();
                }
                
            }
        }

        void createarraybutton5(DataTable dtphong, int top, ref int t)
        {

            int left = 10;
            for (int i = 0; i < dtphong.Rows.Count; i++)
            {
                Button bt = new Button();


                bt.Name = string.Format("btn{0}", dtphong.Rows[i][0].ToString());
                bt.Tag = string.Format("[{0}]", i);
                bt.Text = string.Format("Phòng {0}", dtphong.Rows[i][0].ToString());
                bt.Size = new Size(150, 120);
                bt.Top = top;
                bt.Left = left;
                left += 180;

                if (dtphong.Rows[i][5].ToString() == "Co Nguoi")
                {
                    bt.BackColor = Color.Red;
                }
                else
                {
                    bt.BackColor = DefaultBackColor;
                }

                bt.MouseDown += new MouseEventHandler(bt_Click5);
                groupBox5.Controls.Add(bt);
               
                t++;

                string txt = bt.Text;
                Thue tr = new Thue(txt,this,bt);
            }
        }

        void createarraybutton4(DataTable dtphong, int top, ref int t)
        {

            int left = 10;
            for (int i = 0; i < dtphong.Rows.Count; i++)
            {
                Button bt = new Button();

                bt.Name = string.Format("btn{0}", dtphong.Rows[i][0].ToString());
                bt.Tag = string.Format("[{0}]", i);
                bt.Text = string.Format("Phòng {0}", dtphong.Rows[i][0].ToString());
                bt.Size = new Size(150, 120);
                bt.Top = top;
                bt.Left = left;
                left += 180;

                if (dtphong.Rows[i][5].ToString() == "Co Nguoi")
                {
                    bt.BackColor = Color.Red;
                }
                else
                {
                    bt.BackColor = DefaultBackColor;
                }

                bt.MouseDown += new MouseEventHandler(bt_Click4);
                groupBox4.Controls.Add(bt);

                t++;

                string txt = bt.Text;
               
            }
        }

        void createarraybutton7(DataTable dtphong, int top, ref int t)
        {

            int left = 10;
            for (int i = 0; i < dtphong.Rows.Count; i++)
            {
                Button bt = new Button();

                bt.Name = string.Format("btn{0}", dtphong.Rows[i][0].ToString());
                bt.Tag = string.Format("[{0}]", i);
                bt.Text = string.Format("Phòng {0}", dtphong.Rows[i][0].ToString());
                bt.Size = new Size(150, 120);
                bt.Top = top;
                bt.Left = left;
                left += 180;

                if (dtphong.Rows[i][5].ToString() == "Co Nguoi")
                {
                    bt.BackColor = Color.Red;
                }
                else
                {
                    bt.BackColor = DefaultBackColor;
                }

                bt.MouseDown += new MouseEventHandler(bt_Click7);
                groupBox7.Controls.Add(bt);

                t++;

                string txt = bt.Text;
               
            }
        }

        private void lbx_MouseLeave(object sender, EventArgs e)
        {
            ((ListBox)sender).Controls.Remove(((ListBox)sender));
        }

        private void lbx_DoubleClick(object sender, System.EventArgs e)
        {
            string item = "";

            //foreach (int i in ((ListBox)sender).SelectedIndices)
            //{
            //    item += ((ListBox)sender).Items[i] + Environment.NewLine;

            //}

            if (((ListBox)sender).SelectedIndex == 0)
            {
                //MessageBox.Show(item , "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes);
                MessageBox.Show("Bạn Rất Đẹp Trai", "Thông Báo");
                //((ListBox)sender).Controls.Remove(((ListBox)sender));
            }
            if (((ListBox)sender).SelectedIndex == 1)
            {
                //MessageBox.Show(item, "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes);
                MessageBox.Show("Bạn là chó", "Thông Báo");
                //((ListBox)sender).Controls.Remove(((ListBox)sender));
            }
            if (((ListBox)sender).SelectedIndex == 2)
            {
                //MessageBox.Show(item, "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes);
                MessageBox.Show("Chào " + item, "Thông Báo");
                //((ListBox)sender).Controls.Remove(((ListBox)sender));
            }




            //MessageBox.Show(item);
            //((ListBox)sender).Controls.Remove(((ListBox)sender));
            //MessageBox.Show("hello");  
        }

        private void groupBox5_Paint(object sender, PaintEventArgs e)
        {
            DataTable dttang = new DataTable();
            int top = 45;
            int toplb = 20;
           
            dttang = tang.GetTang();
            for (int i = 0; i < dttang.Rows.Count; i++)
            {
                //tao label hien thi tang
                Label lb = new Label();
                lb.Name = string.Format("lb{0}", i);
                lb.Text = string.Format("TẦNG {0}", dttang.Rows[i][0].ToString());
              
                lb.Top = toplb;
                lb.Left = 10;
                groupBox5.Controls.Add(lb);
                toplb += 150;
                //   
                int sobt = 0;
                PhongEntities phongE = new PhongEntities();
                PhongBUS phongB = new PhongBUS();
                DataTable dtphong = new DataTable();
                dtphong = phongB.GetPhongTheoTang(Convert.ToInt32(dttang.Rows[i][0].ToString()));
                createarraybutton5(dtphong,top, ref sobt);
                top += 150;
            }
        }

        private void groupBox4_Paint(object sender, PaintEventArgs e)
        {
            DataTable dttang = new DataTable();
            int top = 45;
            int toplb = 20;

            dttang = tang.GetTang();
            for (int i = 0; i < dttang.Rows.Count; i++)
            {
                //tao label hien thi tang
                Label lb = new Label();
                lb.Name = string.Format("lb{0}", i);
                lb.Text = string.Format("TẦNG {0}", dttang.Rows[i][0].ToString());

                lb.Top = toplb;
                lb.Left = 10;
                groupBox4.Controls.Add(lb);
                toplb += 150;
                //   
                int sobt = 0;
                PhongEntities phongE = new PhongEntities();
                PhongBUS phongB = new PhongBUS();
                DataTable dtphong = new DataTable();
                dtphong = phongB.GetPhongTheoTang(Convert.ToInt32(dttang.Rows[i][0].ToString()));
                createarraybutton4(dtphong, top, ref sobt);
                top += 150;
            }
        }

        private void groupBox7_Paint(object sender, PaintEventArgs e)
        {
            DataTable dttang = new DataTable();
            int top = 45;
            int toplb = 20;

            dttang = tang.GetTang();
            for (int i = 0; i < dttang.Rows.Count; i++)
            {
                //tao label hien thi tang
                Label lb = new Label();
                lb.Name = string.Format("lb{0}", i);
                lb.Text = string.Format("TẦNG {0}", dttang.Rows[i][0].ToString());

                lb.Top = toplb;
                lb.Left = 10;
                groupBox7.Controls.Add(lb);
                toplb += 150;
                //   
                int sobt = 0;
                PhongEntities phongE = new PhongEntities();
                PhongBUS phongB = new PhongBUS();
                DataTable dtphong = new DataTable();
                dtphong = phongB.GetPhongTheoTang(Convert.ToInt32(dttang.Rows[i][0].ToString()));
                createarraybutton7(dtphong, top, ref sobt);
                top += 150;
            }
        }



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textbox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_DangNhap.PerformClick();
            }

        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_MatKhau.Focus();
            }
        }

        private void btn_ThemNguoiThue_Click(object sender, EventArgs e)
        {
            //int mm = dataGridView3.CurrentCell.RowIndex;
            //int m = Convert.ToInt32(dataGridView3.Rows[mm].Cells[0].Value.ToString());
            //string a = dataGridView3.Rows[mm].Cells[1].Value.ToString();
            //string b = (dataGridView3.Rows[mm].Cells[2].Value.ToString());
            //bool c = Convert.ToBoolean(dataGridView3.Rows[mm].Cells[3].Value.ToString());
            

            //MessageBox.Show("Them KhachThue Thanh Cong");
            //txt_TenNgThue.Text = txt_DiaChiNgThue.Text = txt_SdtNgThue.Text = txt_CmndNgThue.Text = null;
            //ck_NamKhachThue.Checked = ck_NuKhachThue.Checked = false;

        }
        private void btn_CapNhatNV_Click(object sender, EventArgs e)
        {

            int mm = dataGridView3.CurrentCell.RowIndex;
            int m = Convert.ToInt32(dataGridView3.Rows[mm].Cells[0].Value.ToString());
            string a = dataGridView3.Rows[mm].Cells[1].Value.ToString();
            string b = (dataGridView3.Rows[mm].Cells[2].Value.ToString());
            bool c = Convert.ToBoolean(dataGridView3.Rows[mm].Cells[3].Value.ToString());
            string d = (dataGridView3.Rows[mm].Cells[4].Value.ToString());
            string ee = (dataGridView3.Rows[mm].Cells[5].Value.ToString());
            int f = Convert.ToInt32(dataGridView3.Rows[mm].Cells[6].Value.ToString());
            string g = (dataGridView3.Rows[mm].Cells[7].Value.ToString());
            string h = (dataGridView3.Rows[mm].Cells[8].Value.ToString());
            string i = (dataGridView3.Rows[mm].Cells[9].Value.ToString());
            string j = (dataGridView3.Rows[mm].Cells[10].Value.ToString());
            string k = (dataGridView3.Rows[mm].Cells[11].Value.ToString());
            int l = Convert.ToInt32(dataGridView3.Rows[mm].Cells[12].Value.ToString());


            qlnv.GetUpdateNVBUS(a, b, c, d, ee, f, g, h, i, j, k, l, m);
            MessageBox.Show("Capnhat tc");
        }


        private void Btn_themNV(object sender, EventArgs e)
        {
            QuanLyNhanVienEntities a = new QuanLyNhanVienEntities();


            a.MaNV = Convert.ToInt32(txt_MaNV_Them.Text);
            a.Ten = txt_TenNV.Text;
            a.NgaySinh = dateTime_NV.Text;

            if (ck_NamNV.Checked == true)
            {
                a.GioiTinh = true;
            }
            else
                a.GioiTinh = false;
            if (ck_NuNV.Checked == true)
            {
                a.GioiTinh = false;
            }
            else
                a.GioiTinh = true;
            ////a.GioiTinh = ;
            a.ThuongTru = txt_ThuongTruNV.Text;
            a.TamTru = txt_TamTruNV.Text;
            a.Cmnd = Convert.ToInt32(txt_CmndNV.Text);
            a.NgayCap = dateTime_NgayCapNV.Text;
            a.NoiCap = comboBox_NoiCapNV.Text;
            a.Email = txt_EmailNV.Text;
            a.BoPhan = comboBox_BoPhanNV.Text;
            a.NgayVao = dateTime_NgayVaoNV.Text;
            a.SDT = Convert.ToInt32(txt_SdtNV.Text);

            QuanLyNhanVienBUS abus = new QuanLyNhanVienBUS();
            DataTable dt = abus.GetThemNVBUS(a);

            MessageBox.Show("Them Thanh Cong");
            txt_MaNV_Them.Text = txt_TenNV.Text = txt_ThuongTruNV.Text = txt_TamTruNV.Text = txt_CmndNV.Text = comboBox_NoiCapNV.Text = txt_EmailNV.Text = comboBox_BoPhanNV.Text = txt_SdtNV.Text= null;
            ck_NamNV.Checked = ck_NuNV.Checked = false;
            dateTime_NV.Value = dateTime_NgayCapNV.Value = dateTime_NgayVaoNV.Value = System.DateTime.Today;

            //TP_themnv.Refresh();
        }

        private void btn_TimHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }
    }
}
