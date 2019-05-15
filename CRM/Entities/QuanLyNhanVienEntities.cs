using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class QuanLyNhanVienEntities
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

        private string ten;

        public int Ten
        {
            get
            {
                return Ten;
            }

            set
            {
                Ten = value;
            }
        }

        private DateTime ngaysinh;

        public int NgaySinh
        {
            get
            {
                return NgaySinh;
            }

            set
            {
                NgaySinh = value;
            }
        }

        private bool gioitinh;

        public int GioiTinh
        {
            get
            {
                return GioiTinh;
            }

            set
            {
                GioiTinh = value;
            }
        }

        private string thuongtru;

        public string ThuongTru
        {
            get
            {
                return ThuongTru;
            }

            set
            {
                ThuongTru = value;
            }
        }

        private string tamtru;

        public string TamTru
        {
            get
            {
                return TamTru;
            }

            set
            {
                TamTru = value;
            }
        }

        private int cmnd;

        public int CMND
        {
            get
            {
                return CMND;
            }

            set
            {
                CMND = value;
            }
        }

        private DateTime ngaycap;

        public DateTime NgayCap
        {
            get
            {
                return NgayCap;
            }

            set
            {
                NgayCap = value;
            }
        }

        private string noicap;

        public string NoiCap
        {
            get
            {
                return NoiCap;
            }

            set
            {
                NoiCap = value;
            }
        }

        private string email;

        public string Email
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
            }
        }

        private string bophan;

        public string BoPhan
        {
            get
            {
                return BoPhan;
            }

            set
            {
                BoPhan = value;
            }
        }

        private DateTime ngayvao;

        public DateTime NgayVao
        {
            get
            {
                return NgayVao;
            }

            set
            {
                NgayVao = value;
            }
        }

        private int sdt;

        public int SDT
        {
            get
            {
                return SDT;
            }

            set
            {
                SDT = value;
            }
        }

        public QuanLyNhanVienEntities()
        {
        }

        public QuanLyNhanVienEntities(int id, string ten, DateTime ngaysinh, Boolean gioitinh, string thuongtru , string tamtru, int cmnd, DateTime ngaycap, string noicap, string email, string bophan, DateTime ngayvao, int sdt)
        {
            this.id = id;
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
