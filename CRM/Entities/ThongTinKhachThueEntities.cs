﻿using System;
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
            { return cmnd; }
            set
            { cmnd = value; }
        }
        
        private string ten;
        public string Ten
        {
            get
            { return ten; }
            set
            { ten = value; }
        }
        private bool gioitinh;
        public bool GioiTinh
        {
            get
            { return gioitinh; }
            set
            { gioitinh = value; }
        }
        private int sdt;
        public int Sdt
        {
            get
            { return sdt; }
            set
            { sdt = value; }
        }
        private string hinhanh;
        public string HinhAnh
        {
            get
            { return hinhanh; }
            set
            { hinhanh = value; }
        }
        private int phongid;
        public int PhongId
        {
            get
            { return phongid; }
            set
            { phongid = value; }
        }
        private string ngaysinh;
        public string NgaySinh
        {
            get
            { return ngaysinh; }
            set
            { ngaysinh = value; }
        }

        public ThongTinKhachThueEntities()
        {
        }
        public ThongTinKhachThueEntities(int chungminhnhandan, string ten, bool gioitinh, int sodienthoai, string hinhanh, int phongid,string ngaysinh)
        {
            this.cmnd = chungminhnhandan;
            
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.sdt = sodienthoai;
            this.hinhanh = hinhanh;
            this.phongid = phongid;
            this.ngaysinh = ngaysinh;
        }
    }
}
