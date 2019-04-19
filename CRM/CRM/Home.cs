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

        public Home()
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=KRISHNA-PC\\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True";

            InitializeComponent();
            

            tabControl1.TabPages.Remove(tab1);
            tabControl1.TabPages.Remove(tab5);
            tabControl1.TabPages.Remove(tab2);
            tabControl1.TabPages.Remove(tab3);
            tabControl1.TabPages.Remove(tab4);
            tabControl1.TabPages.Remove(tab8);
            tabControl1.TabPages.Remove(tab6);
            tabControl1.TabPages.Remove(tab7);
            //tabControl1.Visible = false;
        }

        

        private void Home_Load(object sender, EventArgs e)
        {
        //TODO: This line of code loads data into the 'sTUDENTDataSet.login' table.You can move, or remove it, as needed.  
        //    this.loginTableAdapter.Fill(this.sTUDENTDataSet.login);
        //    SqlConnection con = new SqlConnection("Data Source=KRISHNA-PC\\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True");
        //    con.Open();

            //{
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sÁToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

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

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font closefont = new Font(e.Font.FontFamily, e.Font.Size, FontStyle.Bold);
            Font titlefont = new Font(e.Font.FontFamily, e.Font.Size, FontStyle.Italic);
            if (e.Index >= 0)
            {
                e.Graphics.DrawString("X ", closefont, Brushes.Black, e.Bounds.Right - 12, e.Bounds.Top + 5);
            }
            e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, titlefont, Brushes.Black, e.Bounds.Left, e.Bounds.Top + 5);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tab1))//tab already present
            {
                tabControl1.SelectTab(tab1);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(tab1); // add removed tab
                tabControl1.SelectTab(tab1);    // select by name
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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabControl1.TabPages.Count; i++)
            {
                Rectangle rPage = tabControl1.GetTabRect(i);
                Rectangle closeButton = new Rectangle(rPage.Right - 15, rPage.Top + 5, 10, 10);
                if (closeButton.Contains(e.Location))
                {

                    if (MessageBox.Show("Bạn Có Muốn Tắt Tab Này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        this.tabControl1.TabPages.RemoveAt(i);
                        break;


                    }

                }
            }
        }

        private void tab1_Click(object sender, EventArgs e)
        {

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

        private void button17_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {

            TaiKhoangEntities log = new TaiKhoangEntities();
            log.Taikhoan = "asdfg";
            log.Matkhau = "123";
            TaiKhoanBUS logbus = new TaiKhoanBUS();
            DataTable dt = logbus.getTK(log);
            if (dt.Rows.Count > 0)
                MessageBox.Show("Welcome to NoWhere !!");
            else
                MessageBox.Show("Đăng nhập thất bại !!!");
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=KRISHNA-PC\\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True";
            //con.Open();
            //string userid = textBox1.Text;
            //string password = textBox2.Text;
            //SqlCommand cmd = new SqlCommand("select userid,password from login where userid='" + textBox1.Text + "'and password='" + text            Box2.Text + "'", con);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //if (dt.Rows.Count > 0)
            //{
            //    MessageBox.Show("Login sucess Welcome to NoWhere !!! ");
            //    System.Diagnostics.Process.Start("Halolo");
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Login please check username and password");
            //}
            //con.Close();
        }
    }
}
