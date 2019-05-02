using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class TaiKhoanEntities
    {
        private int id;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        private string taikhoan;

        public string Taikhoan
        {
            get
            {
                return taikhoan;
            }

            set
            {
                taikhoan = value;
            }
        }


        private string matkhau;
        public string Matkhau
        {
            get
            {
                return matkhau;
            }

            set
            {
                matkhau = value;
            }
        }

        private string loai;
        public string Loai
        {
            get
            {
                return loai;
            }

            set
            {
                loai = value;
            }
        }

        public TaiKhoanEntities()
        {
        }
        public TaiKhoanEntities(int id, string tk, string mk, string mkl)
        {
            this.id = id;
            this.taikhoan = tk;
            this.matkhau = mk;
            this.loai = mkl;
        }

    }
    public class Phong
    {
        private int id;
        public int Id
        {
            get
            {return id;}
            set
            {id = value;}
        }
        private string dientich;
        public string DienTich
        {
            get
            { return DienTich; }
            set
            { DienTich = value; }
        }
        private string huong;
        public string Huong
        {
            get
            { return Huong; }
            set
            { Huong = value; }
        }
        private int loaiphongid;
        public int LoaiPhongId
        {
            get
            { return LoaiPhongId; }
            set
            { LoaiPhongId = value; }
        }
        private int sodien;
        public int SoDien
        {
            get
            { return SoDien; }
            set
            { SoDien = value; }
        }
        private int sonuoc;
        public int SoNuoc
        {
            get
            { return SoNuoc; }
            set
            { SoNuoc = value; }
        }
        private string hientrang;
        public string HienTrang
        {
            get
            { return HienTrang; }
            set
            { HienTrang = value; }
        }
        private int giaca;
        public int GiaCa
        {
            get
            { return GiaCa; }
            set
            { GiaCa = value; }
        }
        public Phong()
        {
        }
        public Phong(int id, string dt, string h, int lp, int sd, int sn, string ht, int gc)
        {
            this.id = id;
            this.dientich = dt;
            this.huong = h;
            this.sodien = sd;
            this.sonuoc = sn;
            this.hientrang = ht;
            this.giaca = gc;
        }
    }
    public class ThanhToan
    {
        private int id;
        public int Id
        {
            get
            { return id; }
            set
            { id = value; }
        }
        private int tiendichvu;
        public int TienDichVu
        {
            get
            { return TienDichVu; }
            set
            { TienDichVu = value; }
        }
        private DateTime ngaythanhtoan;
        public DateTime NgayThanhToan
        {
            get
            { return NgayThanhToan; }
            set
            { NgayThanhToan = value; }
        }
        private int phongid;
        public int PhongId
        {
            get
            { return PhongId; }
            set
            { PhongId = value; }
        }
        private int sodien;
        public int SoDien
        {
            get
            { return SoDien; }
            set
            { SoDien = value; }
        }
        private int sonuoc;
        public int SoNuoc
        {
            get
            { return SoNuoc; }
            set
            { SoNuoc = value; }
        }
        public ThanhToan()
        {
        }
        public ThanhToan(int id, DateTime ntt, int pid, int sd, int sn, int tdv)
        {
            this.id = id;
            this.ngaythanhtoan = ntt;
            this.phongid = pid;
            this.sodien = sd;
            this.sonuoc = sn;
            this.tiendichvu = tdv;
        }
    }
    public class ThongTinKhachThue
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
        public ThongTinKhachThue()
        {
        }
        public ThongTinKhachThue(int cmt, int tkid, string t, bool gt, string dt, string ha, int pid)
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
