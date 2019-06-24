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
        
        public DataTable GetUpdateNVBUS (string a, string b, bool c, string d, string ee, int f, string g, string h, string i, string j, string k, int l, int m)
        {
            DataTable dt = null;
            dt = addDAO.GetUpdateNVDAO(a,b,c,d,ee,f,g,h,i,j,k,l,m);
            return dt;
        }



    }
}
