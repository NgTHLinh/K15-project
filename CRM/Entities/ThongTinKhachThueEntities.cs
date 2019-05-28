using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class ThongTinKhachThueEntities
    {
        private int cmnd;
        public int Cmnd
        {
            get
            { return Cmnd; }
            set
            { Cmnd = value; }
        }
        private int taikhoanid;
        public int TaiKhoanID
        {
            get
            { return TaiKhoanID; }
            set
            { TaiKhoanID = value; }
        }
        private string ten;
        public string Ten
        {
            get
            { return Ten; }
            set
            { Ten = value; }
        }
        private bool gioitinh;
        public bool GioiTinh
        {
            get
            { return GioiTinh; }
            set
            { GioiTinh = value; }
        }
        private string sdt;
        public string Sdt
        {
            get
            { return Sdt; }
            set
            { Sdt = value; }
        }
        private string hinhanh;
        public string HinhAnh
        {
            get
            { return HinhAnh; }
            set
            { HinhAnh = value; }
        }
        private int phongid;
        public int PhongId
        {
            get
            { return PhongId; }
            set
            { PhongId = value; }
        }
        private string ngaysinh;
        public string NgaySinh
        {
            get
            { return NgaySinh; }
            set
            { NgaySinh = value; }
        }

        public ThongTinKhachThueEntities()
        {
        }
        public ThongTinKhachThueEntities(int chungminhnhandan, int taikhoanid, string ten, bool gioitinh, string sodienthoai, string hinhanh, int phongid,string ngaysinh)
        {
            this.cmnd = chungminhnhandan;
            this.taikhoanid = taikhoanid;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.sdt = sodienthoai;
            this.hinhanh = hinhanh;
            this.phongid = phongid;
            this.ngaysinh = ngaysinh;
        }
    }
}
