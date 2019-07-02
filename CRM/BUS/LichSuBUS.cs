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
        public DataTable GetBUS(LichSuEntities add)
        {
            DataTable dt = null;
            dt = nvmDAO.GetTT(add);
            return dt;
        }
        public DataTable GetmBUS(LichSuEntities l)
        {
            DataTable dt = null;
            dt = nvmDAO.Getm(l);
            return dt;
        }
        public DataTable GetmmBUS(LichSuEntities l)
        {
            DataTable dt = null;
            dt = nvmDAO.Getmm(l);
            return dt;
        }
        public DataTable GetmmmBUS(LichSuEntities l)
        {
            DataTable dt = null;
            dt = nvmDAO.Getmmm(l);
            return dt;
        }
    }
}
