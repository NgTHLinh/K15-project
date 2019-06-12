using Entities;
using System.Data;

namespace DAO
{
    
        public class ThongTinKhachThueDAO : DataProvider
        {
            public ThongTinKhachThueDAO() : base()
            {

            }
            //public DataTable GetTK(ThongTinKhachThueEntities user)
            //{
            //    string sql = "select * from ThongTinKhachThue  ";

            //    return getDataTable(sql);
            //}
            public DataTable GetTT(ThongTinKhachThueEntities ttkt) 
            {
                string sql = "select * from ThongTinKhachThue";
                return getDataTable(sql);
            }
        }
 }

