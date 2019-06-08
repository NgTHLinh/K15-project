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

        public DataTable GetTK()
        {
            DataTable dt = new DataTable();
            dt = userTTDAO.GetTT();
            return dt;
        }

    }


}
