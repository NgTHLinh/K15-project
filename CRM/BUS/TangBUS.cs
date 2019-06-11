using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
    public class TangBUS
    {
        private TangDAO tangDAO;
        public TangBUS()
        {

            tangDAO = new TangDAO();
        }

        public DataTable GetTang()
        {
            DataTable dt = null;

            dt = tangDAO.GetTang();

            return dt;
        }
    }
}
