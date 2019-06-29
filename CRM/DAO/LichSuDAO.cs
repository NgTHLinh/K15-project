using Entities;
using System.Data;

namespace DAO
{
    public class LichSuDAO : DataProvider
    {
        public LichSuDAO():base()
        { }
        public DataTable ThemLS(LichSuEntities add)
        {
            string sql = "insert into LichSu ('ID','Ten','NgaySinh','GioiTinh','Cmnd','NgayCap','NoiCap','NgayVao','Sdt') values ('" + add.ID + "','" + add.Ten + "','" + add.NgaySinh + "','" + add.GioiTinh + "','" + add.CMND + "','" + add.NgayCap + "','" + add.NoiCap + "','" + add.NgayVao + "','" + add.Sdt + "')";

            return getDataTable(sql);
        }
    }
}
