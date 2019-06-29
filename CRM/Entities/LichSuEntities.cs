using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class LichSuEntities
    {
        private int id;
        public int ID
        {
            get
            { return id; }
            set
            { id = value; }
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
        private int cmnd;
        public int CMND
        {
            get
            { return cmnd; }
            set
            { cmnd = value; }
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
        private string ngaycap;
        public string NgayCap
        {
            get
            { return ngaycap; }
            set
            { ngaycap = value; }
        }
        private string noicap;
        public string NoiCap
        {
            get
            { return noicap; }
            set
            { noicap = value; }
        }
        private string ngayvao;
        public string NgayVao
        {
            get
            { return ngayvao; }
            set
            { ngayvao = value; }
        }


        public LichSuEntities()
        {
        }
        public LichSuEntities(int id, string ten, string ngaysinh, bool gioitinh, int cmnd, string ngaycap, string noicap, string ngayvao, int sodienthoai, string hinhanh, int phongid)
        {
            this.id = id;

            this.ten = ten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.cmnd = cmnd;
            this.ngaycap = ngaycap;
            this.noicap = noicap;
            this.ngayvao = ngayvao;
            this.sdt = sodienthoai;
            this.hinhanh = hinhanh;
            this.phongid = phongid;

        }
    }
}
