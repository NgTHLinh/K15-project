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
        public Home()
        {
            
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=KRISHNA-PC\\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True";

            InitializeComponent();

            
        
            tabControl1.TabPages.Remove(tab_ThemNgThue);
            tabControl1.TabPages.Remove(tab5);
            tabControl1.TabPages.Remove(tab2);
            tabControl1.TabPages.Remove(tab3);
            tabControl1.TabPages.Remove(tab4);
            tabControl1.TabPages.Remove(tab8);
            tabControl1.TabPages.Remove(tab6);
            tabControl1.TabPages.Remove(tab7);
            tabControl1.TabPages.Remove(tabPage1);
            //tabControl1.Visible = false;
        }



        private void Home_Load(object sender, EventArgs e)
        {
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox3.Checked = false;
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
            if (tabControl1.TabPages.Contains(tab9))//tab already present
            {
                tabControl1.SelectTab(tab9);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(tab9); // add removed tab
                tabControl1.SelectTab(tab9);    // select by name
            }

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tab_ThemNgThue))//tab already present
            {
                tabControl1.SelectTab(tab_ThemNgThue);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(tab_ThemNgThue); // add removed tab
                tabControl1.SelectTab(tab_ThemNgThue);    // select by name
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tab7))//tab already present
            {
                tabControl1.SelectTab(tab7);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(tab7); // add removed tab
                tabControl1.SelectTab(tab7);    // select by name
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tab3))//tab already present
            {
                tabControl1.SelectTab(tab3);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(tab3); // add removed tab
                tabControl1.SelectTab(tab3);    // select by name
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tab2))//tab already present
            {
                tabControl1.SelectTab(tab2);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(tab2); // add removed tab
                tabControl1.SelectTab(tab2);    // select by name
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tab6))//tab already present
            {
                tabControl1.SelectTab(tab6);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(tab6); // add removed tab
                tabControl1.SelectTab(tab6);    // select by name
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tab5))//tab already present
            {
                tabControl1.SelectTab(tab5);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(tab5); // add removed tab
                tabControl1.SelectTab(tab5);    // select by name
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tab8))//tab already present
            {
                tabControl1.SelectTab(tab8);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(tab8); // add removed tab
                tabControl1.SelectTab(tab8);    // select by name
            }


        }
        private void button86_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tab4))//tab already present
            {
                tabControl1.SelectTab(tab4);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(tab4); // add removed tab
                tabControl1.SelectTab(tab4);    // select by name
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            


        }

        private void Btn_themNV(object sender, EventArgs e)
        {
            QuanLyNhanVienEntities a = new QuanLyNhanVienEntities();


            a.MaNV = Convert.ToInt32(txt_MaNV_Them.Text);
            a.Ten = txt_TenNV.Text;
            a.NgaySinh = dateTime_NV.Text;
           
            if (checkBox3.Checked == true)
            {
                a.GioiTinh = true;
            }
            else
                a.GioiTinh = false;
            if (checkBox4.Checked == true)
            {
                a.GioiTinh = false;
            }
            else
                a.GioiTinh = true;
            ////a.GioiTinh = ;
            a.ThuongTru = txt_ThuongTruNV.Text;
            a.TamTru = txt_TamTruNV.Text;
            a.CMND = Convert.ToInt32(txt_CmndNV.Text);
            a.NgayCap = dateTime_NgayCapNV.Text;
            a.NoiCap = comboBox_NoiCapNV.Text;
            a.Email = txt_EmailNV.Text;
            a.BoPhan = comboBox_BoPhanNV.Text;
            a.NgayVao = dateTime_NgayVaoNV.Text;
            a.SDT = Convert.ToInt32(txt_SdtNV);

            QuanLyNhanVienBUS abus = new QuanLyNhanVienBUS();
            DataTable dt = abus.GetNV(a);

            if (dt.Rows.Count > 0)
            {
                addlogin.MaNV = Convert.ToInt32(dt.Rows[0][0].ToString());
                addlogin.Ten = dt.Rows[0][1].ToString();

                MessageBox.Show("Them Thanh Cong");
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
                        
                        //this.Visible = false;
                        break;
                    case "2":
                        MessageBox.Show("Welcome NhanVien " + userlogin.Taikhoan);
                        tabControl1.TabPages.Remove(tab8);
                        
                        tabControl2.TabPages.Remove(TP_QlNgThue);
                        tabControl2.TabPages.Remove(TP_QlNv);
                        btn_Login.Hide();
                        //zzz.TabPages.Remove(tab2_p);
                        break;
                    case "3":
                        MessageBox.Show("Welcome KhachHang " + userlogin.Taikhoan);
                        
                        btn_Login.Hide();
                        break;
                    
                }

               // if (userlogin.Loai == 3)//la nhan vien}
                    //MessageBox.Show("Welcome to NoWhere !!");
            }
            else
                MessageBox.Show("Đăng nhập thất bại !!!");

        }

        

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            int x = 0;
            for (int i = 0; i <= 5; i++)
            {
                Button button = new Button();
                
                if (i == 0)
                {
                    button.Location = new Point(12, 42);
                }
                else
                {
                    button.Location = new Point(x, 42);
                }                
                x = button.Location.X + 220 + 40;
                button.Text = "123";
                button.Size = new Size(220, 150);
                button.Visible = true;
                button.BringToFront();
                button.Tag = i;
                tabPage1.Controls.Add(button);
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

        
    }
}
