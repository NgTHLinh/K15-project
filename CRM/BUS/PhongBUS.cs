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
        public DataTable GetUpdate(PhongEntities up)
        {
            DataTable dt = null;
            dt = phongDAO.UpdatePhong(up);
            return dt;
        }
        public DataTable CheckmauBUS(PhongEntities ck)
        {
            DataTable dt = null;
            dt = phongDAO.CheckPhong(ck);
            return dt;
        }
    }
}
