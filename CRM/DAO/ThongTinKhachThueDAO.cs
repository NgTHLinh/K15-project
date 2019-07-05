using Entities;
using System.Data;

namespace DAO
{
    
        public class ThongTinKhachThueDAO : DataProvider
        {
            public ThongTinKhachThueDAO() : base()
            {

            }
        public DataTable GetTK(ThongTinKhachThueEntities user)
        {
            string sql = "select * from ThongTinKhachThue where Ten!='' ";

            return getDataTable(sql);
        }
        public DataTable GetTT(ThongTinKhachThueEntities ttkt) 
            {
                string sql = "select * from ThongTinKhachThue";
                return getDataTable(sql);
            }

        public DataTable GetKT(ThongTinKhachThueEntities add )
        {
            string sql = "update ThongTinKhachThue set Ten='" + add.Ten + "',NgaySinh='" + add.NgaySinh + "',GioiTinh='" + add.GioiTinh + "',Cmnd='"+add.CMND+"',NgayCap='"+add.NgayCap+"',NoiCap='"+add.NgayCap+"',NgayVao='"+add.NgayCap+"',Sdt='"+add.Sdt+"',PhongId='"+add.PhongId+"' where ID="+add.ID;

            return getDataTable(sql);
        }
        public DataTable Getm (ThongTinKhachThueEntities l)
        {
            string sql ="select * from ThongTinKhachThue where Cmnd='"+l.ID+"' and Ten ='"+l.Ten+"'";
            return getDataTable(sql);
        
        }

        public DataTable Get(ThongTinKhachThueEntities l)
        {
            string sql = "select * from ThongTinKhachThue where ID='" + l.ID + "'";
            return getDataTable(sql);

        }
        public DataTable Getmm(ThongTinKhachThueEntities l)
        {
            string sql = "select * from ThongTinKhachThue where Cmnd='" + l.CMND + "'";
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

