using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
    public class HoaDonBUS
    {
        private HoaDonDAO HdDAO;
        public HoaDonBUS()
        {
            HdDAO = new HoaDonDAO();
        }

        public DataTable ThemHDBUS(HoaDonEntities h)
        {
            DataTable dt = null;
            dt = HdDAO.LuuHoaDon(h);
            return dt;
        }
    }
}
