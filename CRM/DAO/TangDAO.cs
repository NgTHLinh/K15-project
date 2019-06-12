using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAO
{
    public class TangDAO : DataProvider
    {
        public TangDAO() : base()
        {

        }
        //public DataTable GetTK(ThongTinKhachThueEntities user)
        //{
        //    string sql = "select * from ThongTinKhachThue  ";

        //    return getDataTable(sql);
        //}
        public DataTable GetTang()
        {
            string sql = "select * from Tang";
            return getDataTable(sql);
        }
    }
}
