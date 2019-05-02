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
        public ThongTinKhachThueEntities()
        {
        }
        public ThongTinKhachThueEntities(int cmt, int tkid, string t, bool gt, string dt, string ha, int pid)
        {
            this.cmnd = cmt;
            this.taikhoanid = tkid;
            this.ten = t;
            this.gioitinh = gt;
            this.sdt = dt;
            this.hinhanh = ha;
            this.phongid = pid;
        }
    }
}
