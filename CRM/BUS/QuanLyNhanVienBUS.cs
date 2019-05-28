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

        public DataTable GetNV (QuanLyNhanVienEntities add)
        {
            DataTable dt = null;
            dt = addDAO.GetNV(add);
            return dt;
        }

    }
}
