using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAO
{
    public class PhongDAO : DataProvider
    {
        public PhongDAO() : base()
        {

        }
        //public DataTable GetTK(ThongTinKhachThueEntities user)
        //{
        //    string sql = "select * from ThongTinKhachThue  ";

        //    return getDataTable(sql);
        //}
        public DataTable GetPhongTheoTang(int id)
        {
            string sql = "select * from Phong where TangID =" + id;
            return getDataTable(sql);
        }
    }
}
