using Entities;
using System.Data;
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

        public DataTable GetTenPhong()
        {
            string sql = "select * from Phong";
            return getDataTable(sql);
        }
        public DataTable UpdatePhong(PhongEntities up)
        {
            string sql = "Update Phong set HienTrang='"+up.HienTrang+"' where ID='"+up.Id+"'";
            return getDataTable(sql);
        }

        public DataTable CheckPhong(PhongEntities ck)
        {
            string sql = "select * from Phong where HienTrang='"+ck.HienTrang+"'";
            return getDataTable(sql);
        }

    }
}
