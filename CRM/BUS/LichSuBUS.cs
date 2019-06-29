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
    public class LichSuBUS
    {
        public LichSuDAO nvmDAO;
        public LichSuBUS()
        {
            nvmDAO = new LichSuDAO();
        }

        public DataTable ThemLSBUS(LichSuEntities ttkt)
        {
            DataTable dt = null;
            dt = nvmDAO.ThemLS(ttkt);
            return dt;
        }
    }
}
