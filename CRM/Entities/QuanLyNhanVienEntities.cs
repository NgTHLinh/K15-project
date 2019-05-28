using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class QuanLyNhanVienEntities
    {
        private int manv;

        public int MaNV 
        {
            get
            {
                return manv;
            }

            set
            {
                manv = value;
            }
        }

        private string ten;

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        private string ngaysinh;

        public string NgaySinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        private bool gioitinh;

        public bool GioiTinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        private string thuongtru;

        public string ThuongTru
        {
            get
            {
                return thuongtru;
            }

            set
            {
                thuongtru = value;
            }
        }

        private string tamtru;

        public string TamTru
        {
            get
            {
                return tamtru;
            }

            set
            {
                tamtru = value;
            }
        }

        private int cmnd;

        public int CMND
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
            }
        }

        private string ngaycap;

        public string NgayCap
        {
            get
            {
                return ngaycap;
            }

            set
            {
                ngaycap = value;
            }
        }

        private string noicap;

        public string NoiCap
        {
            get
            {
                return noicap;
            }

            set
            {
                noicap = value;
            }
        }

        private string email;

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        private string bophan;

        public string BoPhan
        {
            get
            {
                return bophan;
            }

            set
            {
                bophan = value;
            }
        }

        private string ngayvao;

        public string NgayVao
        {
            get
            {
                return ngayvao;
            }

            set
            {
                ngayvao = value;
            }
        }

        private int sdt;

        public int SDT
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }

        public QuanLyNhanVienEntities()
        {
        }

        public QuanLyNhanVienEntities(int manv, string ten, string ngaysinh, Boolean gioitinh, string thuongtru , string tamtru, int cmnd, string ngaycap, string noicap, string email, string bophan, string ngayvao, int sdt)
        {
            this.manv = manv;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.thuongtru = thuongtru;
            this.tamtru = tamtru;
            this.cmnd = cmnd;
            this.ngaycap = ngaycap;
            this.noicap = noicap;
            this.email = email;
            this.bophan = bophan;
            this.ngayvao = ngayvao;
            this.sdt = sdt;
        }

    }
}
