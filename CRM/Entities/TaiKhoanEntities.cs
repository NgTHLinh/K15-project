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
<<<<<<< HEAD
        public TaiKhoanEntities(int id ,string tk, string mk, string tkl)
=======
        public TaiKhoanEntities(int id, string tk, string mk, string mkl)
>>>>>>> 4dae56ba4cd0a2c022d30093fa007be8703f4d53
        {
            this.id = id;
            this.taikhoan = tk;
            this.matkhau = mk;
<<<<<<< HEAD
            this.loai = tkl;
=======
            this.loai = mkl;
>>>>>>> 4dae56ba4cd0a2c022d30093fa007be8703f4d53
        }

    }
}