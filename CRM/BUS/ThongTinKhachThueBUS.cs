using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace BUS
{
    public class ThongTinKhachThueBUS
    {
       
        //public static string str = @"D:\K15-project\NCKH_KhoaLong.db";
        //    //string str = @"C:\Users\DuyKhoa\Documents\GitHub\K15-project\NCKH_KhoaLong.db";
        //    //MessageBox.Show(str);
            
        //       public static string con = @"Data Source = " + str;

        public ThongTinKhachThueDAO userTTDAO;

        public ThongTinKhachThueBUS()
        {

            userTTDAO = new ThongTinKhachThueDAO();
        }

        public DataTable GetTK()
        {
            DataTable dt = new DataTable();
            dt = userTTDAO.GetTT();
            return dt;
        }

    }


}
