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

        public Home()
        {
            InitializeComponent();

            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Remove(tabPage5);
            //tabControl1.Visible = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {

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
            if (tabControl1.TabPages.Contains(tabPage12))//tab already present
            {
                tabControl1.SelectTab(tabPage12);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(tabPage12); // add removed tab
                tabControl1.SelectTab(tabPage12);    // select by name
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
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabPage2))//tab already present
            {
                tabControl1.SelectTab(tabPage2);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(tabPage2); // add removed tab
                tabControl1.SelectTab(tabPage2);    // select by name
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabPage11))//tab already present
            {
                tabControl1.SelectTab(tabPage11);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(tabPage11); // add removed tab
                tabControl1.SelectTab(tabPage11);    // select by name
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabPage4))//tab already present
            {
                tabControl1.SelectTab(tabPage4);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(tabPage4); // add removed tab
                tabControl1.SelectTab(tabPage4);    // select by name
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabPage5))//tab already present
            {
                tabControl1.SelectTab(tabPage5);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(tabPage5); // add removed tab
                tabControl1.SelectTab(tabPage5);    // select by name
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabPage10))//tab already present
            {
                tabControl1.SelectTab(tabPage10);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(tabPage10); // add removed tab
                tabControl1.SelectTab(tabPage10);    // select by name
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabPage1))//tab already present
            {
                tabControl1.SelectTab(tabPage1);  // select by name
            }
            else
            {
                tabControl1.TabPages.Add(tabPage1); // add removed tab
                tabControl1.SelectTab(tabPage1);    // select by name
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
