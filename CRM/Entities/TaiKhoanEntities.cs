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
            { return id; }
            set
            { id = value; }
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

    public class LoaiPhong
    {
        private int id;
        public int Id
        {
            get
            { return id; }
            set
            { id = value; }
        }

        private string hinhanh;
        public string Hinhanh
        {
            get
            { return hinhanh; }
            set
            { hinhanh = value; }
        }

        private string chitiet;
        public string Chitiet
        {
            get
            { return chitiet; }
            set
            { chitiet = value; }
        }

        public LoaiPhong()
        { }
        public LoaiPhong(int id, string ha, string ct)
        {
            this.id = id;
            this.hinhanh = ha;
            this.chitiet = ct;
        }
    }

    public class HopDongPhat
    {
        private int id;
        public int Id
        {
            get
            { return id; }
            set
            { id = value; }
        }

        private int hopdongid;
        public int Hopdongid
        {
            get
            { return hopdongid; }
            set
            { hopdongid = value; }
        }

        private string tenloaiphat;
        public string Tenloaiphat
        {
            get
            { return tenloaiphat; }
            set
            { tenloaiphat = value; }
        }

        private int thanhtien;
        public int Thanhtien
        {
            get
            { return thanhtien; }
            set
            { thanhtien = value; }
        }

        public HopDongPhat()
        { }
        public HopDongPhat(int id, int hdid, string tlp, int tt)
        {
            this.id = id;
            this.hopdongid = hdid;
            this.tenloaiphat = tlp;
            this.thanhtien = tt;

        }
    }

    public class HopDong
    {
        private int id;
        public int Id
        {
            get
            { return id; }
            set
            { id = value; }
        }

        private string cmnd;
        public string Cmnd
        {
            get
            { return cmnd; }
            set
            { cmnd = value; }
        }
        private int phongid;
        public int PhongID
        {
            get
            { return phongid; }
            set
            { phongid = value; }
        }

        private DateTime ngaybatdau;
        public DateTime Ngaybatdau
        {
            get
            { return ngaybatdau; }
            set
            { ngaybatdau = value; }
        }

        private DateTime ngayketthuc;
        public DateTime Ngayketthuc
        {
            get
            { return ngayketthuc; }
            set
            { ngayketthuc = value; }
        }

        private int songuoio;
        public int Songuoio
        {
            get
            { return songuoio; }
            set
            { songuoio = value; }
        }

        private int tiencoc;
        public int Tiencoc
        {
            get
            { return tiencoc; }
            set
            { tiencoc = value; }
        }

        private int chietkhau;
        public int Chietkhau
        {
            get
            { return chietkhau; }
            set
            { chietkhau = value; }
        }

        private int tienhopdong;
        public int Tienhopdong
        {
            get
            { return tienhopdong; }
            set
            { tienhopdong = value; }
        }

        private int tiendien;
        public int Tiendien
        {
            get
            { return tiendien; }
            set
            { tiendien = value; }
        }

        private int tiennuoc;
        public int Tiennuoc
        {
            get
            { return tiennuoc; }
            set
            { tiennuoc = value; }
        }

        private string lietkedichvu;
        public string Lietkedichvu
        {
            get
            { return lietkedichvu; }
            set
            { lietkedichvu = value; }
        }

        public HopDong()
        { }
        public HopDong(int id, string cmnd , int phongid, DateTime ntt, DateTime nkt, int sno, int tcoc, int chietkhau, int tienhopdong, int tiendien, int tiennuoc, string lietkedichvu)
        {
            this.id = id;
            this.cmnd = cmnd;
            this.phongid = phongid;
            this.ngaybatdau = ntt;
            this.ngayketthuc = nkt;
            this.songuoio = sno;
            this.tiencoc = tcoc;
            this.chietkhau = chietkhau;
            this.tienhopdong = tienhopdong;
            this.tiendien = tiendien;
            this.tiennuoc = tiennuoc;
            this.lietkedichvu = lietkedichvu;

        }
    }

    public class DichVu
    {
        private int id;
        public int Id
        {
            get
            { return id; }
            set
            { id = value; }
        }
        private string tendichvu;
        public string Tendichvu
        {
            get
            { return tendichvu; }
            set
            { tendichvu = value; }
        }
        private string chitietdichvu;
        public string Chitietdichvu
        {
            get
            { return chitietdichvu; }
            set
            { chitietdichvu = value; }
        }

        private int soluong;
        public int Soluong
        {
            get
            { return soluong; }
            set
            { soluong = value; }
        }

        private int thanhtien;
        public int Thanhtien
        {
            get
            { return thanhtien; }
            set
            { thanhtien = value; }
        }

        public DichVu()
        { }
        public DichVu ( int id, string tendichvu, string chitietdichvu , int soluong, int thanhtien)
        {
            this.id = id;
            this.tendichvu = tendichvu;
            this.chitietdichvu = chitietdichvu;
            this.soluong = soluong;
            this.thanhtien = thanhtien;
        }
    }
}