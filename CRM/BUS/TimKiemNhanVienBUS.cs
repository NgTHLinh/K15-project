using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
    public class TimKiemNhanVienBUS
    {
        private TimKiemNhanVienDAO timDAO;
        public TimKiemNhanVienBUS()
        {
            timDAO = new TimKiemNhanVienDAO();
        }

        public DataTable GetTKNV (QuanLyNhanVienEntities tim)
        {
            DataTable dt = null;
            dt = timDAO.GetTKNV(tim);
            return dt;
        }
    }
}
