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
    public class ThanhToanBUS
    {
        public ThanhToanDAO nvmTTDAO;
        public ThanhToanBUS()
        {
            nvmTTDAO = new ThanhToanDAO();
        }
        public DataTable GetThanhToanBUS(ThanhToanEntities tt)
        {
            DataTable dt = null;
            dt = nvmTTDAO.GetThanhToan(tt);
            return dt;
        }
    }
}
