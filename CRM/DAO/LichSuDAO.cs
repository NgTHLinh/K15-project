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
        public DataTable GetTT(LichSuEntities ttkt)
        {
            string sql = "select * from LichSu";
            return getDataTable(sql);
        }
        public DataTable Getm(LichSuEntities l)
        {
            string sql = "select * from LichSu where ID='" + l.ID + "' and Ten ='" + (l.Ten) + "'";
            return getDataTable(sql);

        }
        public DataTable Getmm(LichSuEntities l)
        {
            string sql = "select * from LichSu where ID='" + l.ID + "'";
            return getDataTable(sql);

        }
        public DataTable Getmmm(LichSuEntities l)
        {
            string sql = "select * from LichSu where Ten ='" + l.Ten + "'";
            return getDataTable(sql);
        }
    }
}
