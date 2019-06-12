using Entities;
using System.Data;

namespace DAO
{
    public class ThemKhachThueDAO : DataProvider
    {
        public ThemKhachThueDAO():base()
        { }
        public DataTable GetKT(ThongTinKhachThueEntities add)
        {
            string sql = "insert into ThongTinKhachThue ('Ten','NgaySinh','GioiTinh','Cmnd','Sdt') values ('" + add.Ten + "','" + add.NgaySinh + "','" + add.GioiTinh + "','" + add.Cmnd + "','" + add.Sdt + "')";

            return getDataTable(sql);
        }
    }
}
