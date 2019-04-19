using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
     public class TaiKhoanBUS
    {
        private TaiKhoanDAO userDAO;
        public TaiKhoanBUS()
        {
            try
            {
                userDAO = new TaiKhoanDAO();
            }
            catch
            {
                throw;
            }
        }

        public DataTable getTK(TaiKhoangEntities user)
        {
            DataTable dt = null;
            try
            {
                dt = userDAO.getTK(user);
            }
            catch
            {
                throw;
            }
            return dt;
        }

    }


}
