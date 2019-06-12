using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
    public class ThemNhanVienBUS
    {
        private ThemNhanVienDAO addDAO;
        public ThemNhanVienBUS()
        {
            addDAO = new ThemNhanVienDAO();
        }

        public DataTable GetNV (QuanLyNhanVienEntities add)
        {
            DataTable dt = null;
            dt = addDAO.GetNV(add);
            return dt;
        }

    }
}
