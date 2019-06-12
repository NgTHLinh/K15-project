using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
    public class ThemKhachThueBUS
    {
        private ThemKhachThueDAO addDAO;
        public ThemKhachThueBUS()
        {
            addDAO = new ThemKhachThueDAO();
        }

        public DataTable GetKT(ThongTinKhachThueEntities add)
        {
            DataTable dt = null;
            dt = addDAO.GetKT(add);
            return dt;
        }

    }
}
