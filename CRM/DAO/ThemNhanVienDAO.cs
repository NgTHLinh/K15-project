﻿using Entities;
using System.Data;

namespace DAO
{
    public class ThemNhanVienDAO : DataProvider
    {
        public ThemNhanVienDAO():base()
        { }
        public DataTable GetNV(QuanLyNhanVienEntities add)
        {
            string sql = "insert into QuanLyNhanVien /*('ten','ngaysinh','gioitinh','thuongtru','tamtru','cmnd','ngaycap','noicap','email','bophan','ngayvao','sdt')*/ values ('" +add.MaNV +"','" + add.Ten + "','" +add.NgaySinh +"','" + add.GioiTinh + "','" + add.ThuongTru + "','" + add.TamTru + "','" + add.Cmnd + "','" + add.NgayCap + "','" + add.NoiCap + "','" + add.Email + "','" + add.BoPhan + "','" + add.NgayVao + "','" + add.SDT + "')";

            return getDataTable(sql);
        }
    }
}