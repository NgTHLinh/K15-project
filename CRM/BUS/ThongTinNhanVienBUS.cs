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
    public class ThongTinNhanVienBUS
    {
        public ThongTinNhanVienDAO userTTNVDAO;

        public ThongTinNhanVienBUS()
        {
            userTTNVDAO = new ThongTinNhanVienDAO();
        }
        public DataTable GetTTNV ()
        {
            DataTable dt = null;
            dt = userTTNVDAO.GetNV();
            return dt;
        }
    }
}
