using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
    public class QuanLyNhanVienBUS
    {
        private QuanLyNhanVienDAO addDAO;
        public QuanLyNhanVienBUS()
        {
            addDAO = new QuanLyNhanVienDAO();
        }

        public DataTable GetNVBUS(QuanLyNhanVienEntities add)
        {
            DataTable dt = null;
            dt = addDAO.GetNVDAO(add);
            return dt;
        }

        public DataTable GetThemNVBUS(QuanLyNhanVienEntities add)
        {
            DataTable dt = null;
            dt = addDAO.GetThemNVDAO(add);
            return dt;
        }
        

    }
}
