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



//Khoa

namespace CRM
{
    public partial class Home : Form
    {            
        
        //SqlConnection con = new SqlConnection();
        private Point _imageLocation = new Point(22, 0);
        private Point _imageHitArea = new Point(13,2);
        Image CloseImage;

        TaiKhoanEntities userlogin = new TaiKhoanEntities();
        QuanLyNhanVienEntities addlogin = new QuanLyNhanVienEntities();
        ThongTinKhachThueEntities table = new ThongTinKhachThueEntities();
        TangBUS tang = new TangBUS();



        public Home()
        {
            //string conn = "Data Source=D:\\K15-project\\NCKH_KhoaLong.db";
        //SqlConnection con = new SqlConnection(conn);
            //con.ConnectionString = "Data Source=KRISHNA-PC\\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True";
            //con.ConnectionString = "Data Source=D:\\K15-project\\NCKH_KhoaLong.db";
            InitializeComponent();
           
            btn_Logout.Hide();
            btn_Home.Hide();
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
            //tabControl1.TabPages.Remove(tabPage1);
            
        }

        

        private void Home_Load(object sender, EventArgs e)
        {
            {
                ThongTinKhachThueEntities t = new ThongTinKhachThueEntities();
                ThongTinKhachThueBUS ttktbus = new ThongTinKhachThueBUS();
                DataTable dt = ttktbus.GetTK(t);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count;i++)
                    {
                        table.Cmnd = Convert.ToInt32(dt.Rows[i][0].ToString());
                        table.Ten = dt.Rows[i][1].ToString();
                        table.NgaySinh = dt.Rows[i][2].ToString();
                        table.GioiTinh = Convert.ToBoolean(dt.Rows[i][3].ToString());
                        table.Cmnd = Convert.ToInt32(dt.Rows[i][4].ToString());
                        table.Sdt = Convert.ToInt32(dt.Rows[i][5].ToString());

                        dataGridView2.Rows.Add(table.Cmnd, table.Ten, table.NgaySinh, table.GioiTinh, table.Cmnd, table.Sdt);//, table.PhongId);

                    }


                }

            }
            {
                ThongTinNhanVienBUS nv = new ThongTinNhanVienBUS();
                DataTable dt = nv.GetTTNV();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count;i++)
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
            //int w = Screen.PrimaryScreen.Bounds.Width;
            //int h = Screen.PrimaryScreen.Bounds.Height;
            //this.Location = new Point(0, 0);
            //this.Size = new Size(w, h);


            //TODO: This line of code loads data into the 'sTUDENTDataSet.login' table.You can move, or remove it, as needed.  
            //    this.loginTableAdapter.Fill(this.sTUDENTDataSet.login);
            //    SqlConnection con = new SqlConnection("Data Source=KRISHNA-PC\\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True");
            //    con.Open();

            //{
            //}

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

                //if(tabControl1.SelectedIndex >= 1)
                //{
                e.Graphics.DrawImage(img, new Point(r.X + this.tabControl1.GetTabRect(e.Index).Width - _imageLocation.X, _imageLocation.Y));
                //}
            }
            catch (Exception) { }
            //Font closefont = new Font(e.Font.FontFamily, e.Font.Size, FontStyle.Bold);
            //Font titlefont = new Font(e.Font.FontFamily, e.Font.Size, FontStyle.Italic);
            //if (e.Index >= 0)
            //{
            //    e.Graphics.DrawString("X ", closefont, Brushes.Black, e.Bounds.Right - 12, e.Bounds.Top + 5);
            //}
            //e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, titlefont, Brushes.Black, e.Bounds.Left, e.Bounds.Top + 5);

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
            // }
        }

        //private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    for (int i = 0; i <= this.tabControl1.TabPages.Count; i++)
        //    {
        //        Rectangle rPage = tabControl1.GetTabRect(i);
        //        Rectangle closeButton = new Rectangle(rPage.Right - 20, rPage.Top + 5, rPage.Left + 15, 10);
        //        if (closeButton.Contains(e.Location))
        //        {

        //            if (MessageBox.Show("Bạn Có Muốn Tắt Tab Này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //            {

        //                this.tabControl1.TabPages.RemoveAt(i);
        //                break;


        //            }

        //        }
        //    }
        //}

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

        private void button10_Click_1(object sender, EventArgs e)
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


        private void btn_TraCuuNV_Click(object sender, EventArgs e)
        {
            QuanLyNhanVienEntities nv = new QuanLyNhanVienEntities();

            nv.MaNV = Convert.ToInt32(txt_MaNV_TT.Text);
            
            TimKiemNhanVienBUS tim = new TimKiemNhanVienBUS();
            DataTable dt = tim.GetTKNV(nv);
            
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
                addlogin.BoPhan =  dt.Rows[0][10].ToString();
                addlogin.NgayVao = dt.Rows[0][11].ToString();
                addlogin.SDT = Convert.ToInt32(dt.Rows[0][12].ToString());

                //foreach (var item in )
                //{
                //System.Data.DataTable dataTable = new System.Data.DataTable();
                dataGridView3.Rows.Add(addlogin.MaNV,addlogin.Ten, addlogin.NgaySinh, addlogin.GioiTinh, addlogin.ThuongTru, addlogin.TamTru, addlogin.Cmnd, addlogin.NgayCap, addlogin.NoiCap, addlogin.Email, addlogin.BoPhan, addlogin.NgayVao, addlogin.SDT);
                //dataGridView3.DataSource = dt;
                //}

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
                        MessageBox.Show("Welcome Admin");
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

        void createarraybutton(DataTable dtphong, int top, ref int t)
        {

            int left = 0;
            for (int i = 0; i < dtphong.Rows.Count; i++)
            {
                Button bt = new Button();
                bt.Name = string.Format("btn{0}", dtphong.Rows[i][0].ToString());
                bt.Tag = string.Format("[{0}]", i);
                bt.Text = string.Format("Phòng [{0}]", dtphong.Rows[i][0].ToString());
                bt.Size = new Size(50, 50);
                bt.Top = top;
                bt.Left = left;

                left += 80;
                bt.Click += new EventHandler(bt_Click);
                tabPage1.Controls.Add(bt);
                t++;
            }
        }
        private void bt_Click(object sender, EventArgs e)
        {
            Thue p = new Thue();

            p.ShowDialog();
            //MessageBox.Show("ban vua nhan vào phòng " + ((Button)sender).Text);
        }

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            DataTable dttang = new DataTable();
            int top = 50;
            int toplb = 10;
            dttang = tang.GetTang();
            for (int i = 0; i < dttang.Rows.Count; i++)
            {
                //tao label hien thi tang
                Label lb = new Label();
                lb.Name = string.Format("lb{0}", i);
                lb.Text = string.Format("TẦNG {0}", dttang.Rows[i][0].ToString());

                lb.Top = toplb;
                tabPage1.Controls.Add(lb);
                toplb += 100;
                //   
                int sobt = 0;
                PhongEntities phongE = new PhongEntities();
                PhongBUS phongB = new PhongBUS();
                DataTable dtphong = new DataTable();
                dtphong = phongB.GetPhongTheoTang(Convert.ToInt32(dttang.Rows[i][0].ToString()));
                createarraybutton(dtphong, top, ref sobt);
                top += 100;
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            
            Thue p = new Thue();
            
            p.ShowDialog();

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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                      
        }

        private void btn_SuaNgThue_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btn_ThemNguoiThue_Click(object sender, EventArgs e)
        {
            ThongTinKhachThueEntities c = new ThongTinKhachThueEntities();

            c.Ten = txt_TenNgThue.Text;
            c.NgaySinh = dateTime_NgaySinh_NgThue.Text;
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

            c.Cmnd = Convert.ToInt32(txt_CmndNgThue.Text);
            c.Sdt = Convert.ToInt32(txt_SdtNgThue.Text);

            ThemKhachThueBUS cbus = new ThemKhachThueBUS();
            DataTable dt = cbus.GetKT(c);

            MessageBox.Show("Them KhachThue Thanh Cong");

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

            ThemNhanVienBUS abus = new ThemNhanVienBUS();
            DataTable dt = abus.GetNV(a);




            MessageBox.Show("Them Thanh Cong");

            TP_themnv.Refresh();
        }

        
        
    }
}
