using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
    public class PhongBUS
    {
        private PhongDAO phongDAO;
        public PhongBUS()
        {

            phongDAO = new PhongDAO();
        }

        public DataTable GetPhongTheoTang(int id)
        {
            DataTable dt = null;

            dt = phongDAO.GetPhongTheoTang(id);

            return dt;
        }

        public DataTable GetTenPhong()
        {
            DataTable name = null;

            name = phongDAO.GetTenPhong();

            return name;
        }
    }
}
