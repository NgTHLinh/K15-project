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
        public TaiKhoanEntities(int id ,string tk, string mk, string mkl)
        {
            this.id = id;
            this.taikhoan = tk;
            this.matkhau = mk;
            this.loai = mkl;
           
        }

    }
}
