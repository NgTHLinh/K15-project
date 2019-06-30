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
       
        public ThongTinKhachThueDAO userTTDAO;

        public ThongTinKhachThueBUS()
        {

            userTTDAO = new ThongTinKhachThueDAO();
        }

        public DataTable GetTKBUS(ThongTinKhachThueEntities add)
        {
            DataTable dt = null;
            dt = userTTDAO.GetKT(add);
            return dt;
        }
        public DataTable GetmBUS (ThongTinKhachThueEntities l)
        {
            DataTable dt = null;
            dt = userTTDAO.Getm(l);
            return dt;
        }
        public DataTable GetmmBUS(ThongTinKhachThueEntities l)
        {
            DataTable dt = null;
            dt = userTTDAO.Getmm(l);
            return dt;
        }
        public DataTable GetmmmBUS(ThongTinKhachThueEntities l)
        {
            DataTable dt = null;
            dt = userTTDAO.Getmmm(l);
            return dt;
        }
        public DataTable XoaKTBUS(int s)
        {
            DataTable dt = null;
            dt = userTTDAO.XoaKT(s);
            return dt;
        }
    }


}
