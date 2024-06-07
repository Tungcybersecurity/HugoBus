using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class UserAccountBUS
    {
        public DataTable doDuLieu()
        {
            return (new UserAccountDAO().doDuLieu());
        }
        public Parents GetParentByUserName(string tendangnhap)
        {
            return (new UserAccountDAO().GetParentByUserName(tendangnhap));
        }

        public bool DeleteParentByUserName(string tendangnhap)
        {
            return (new UserAccountDAO().DeleteParentByUserName(tendangnhap));
        }

        public bool UpdateParentByUserName(Parents pr , string tendangnhap)
        {
            return (new UserAccountDAO().UpdateParentByUserName(pr, tendangnhap));
        }

       public string getPass(string tendangnhap)
        {
            return (new UserAccountDAO().getPassword(tendangnhap));
        }
        public bool updatePass(string tendangnhap, string pass )
        {
            return (new UserAccountDAO().UpdatePassword(tendangnhap, pass));
        }

        public DataTable getSearch(string loai,string value)
        {
            return (new UserAccountDAO().doDuLieuTimKiem(loai, value));
        }
      
    }
}
