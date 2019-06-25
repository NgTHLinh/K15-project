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
        public DataTable GetKT(ThongTinKhachThueEntities add)
        {
            string sql = "insert into ThongTinKhachThue ('Ten','NgaySinh','GioiTinh','Cmnd','NgayCap','NoiCap','NgayVao','Sdt') values ('" + add.Ten + "','" + add.NgaySinh + "','" + add.GioiTinh + "','" + add.CMND + "','"+add.NgayCap+"','"+add.NoiCap+"','"+add.NgayVao+"','" + add.Sdt + "')";

            return getDataTable(sql);
        }
        public DataTable Getm (ThongTinKhachThueEntities l)
        {
            string sql ="select * from ThongTinKhachThue where ID='"+l.ID+"' and Ten ='"+(l.Ten)+"'";
            return getDataTable(sql);
        
        }
        public DataTable Getmm(ThongTinKhachThueEntities l)
        {
            string sql = "select * from ThongTinKhachThue where ID='" + l.ID + "'";
            return getDataTable(sql);

        }
        public DataTable Getmmm(ThongTinKhachThueEntities l)
        {
            string sql = "select * from ThongTinKhachThue where Ten ='" + l.Ten+"'";
            return getDataTable(sql);
        }
        public DataTable XoaKT(int s)
        {
            string sql = "delete from ThongTinKhachThue where ID=" + s;
            return getDataTable(sql);
        }
    }
 }

