using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class TaiKhoangEntities
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

        

        private string matkhau;

        private string loai;

        public TaiKhoangEntities()
        {
        }
        public TaiKhoangEntities(int id ,string tdn, string mk, string mkd )
        {
            this.id = id;
            this.taikhoan = tdn;
            this.matkhau = mk;
            this.loai = mkd;
           
        }

    }
}
