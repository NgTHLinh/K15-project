using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CRM
{
    public partial class Splash : Form
    {
        int loop = 0;
        public Splash()
        {
            InitializeComponent();
            timer1.Start();
        }

       

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //if (loop < 10000000000000000)
            //{
            //    loop += 50;
            //}
            //else
            //{
            //    timer1.Stop();
            //    this.Close();
            //}
        }

        private void Splash_Load(object sender, EventArgs e)
        {

            Form a = new Home();
            Thread.Sleep(4000);
            this.Hide();
            a.ShowDialog();  
        }
    }

}

