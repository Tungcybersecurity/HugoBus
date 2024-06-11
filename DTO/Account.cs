using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private string tendangnhap;
        private string matkhau;

        public Account()
        {
            this.tendangnhap = "";
            this.matkhau = "";
            
        }

        public string getTenDangNhap()
        {
            return this.tendangnhap;
        }

        public void setTenDangNhap(string tendangnhap)
        {
            this.tendangnhap=tendangnhap;
        }

        public string getMatKhau()
        { 
            return this.matkhau; 
        }

        public void setMatKhau(string matkhau)
        {
            this.matkhau=matkhau;
        }
    }
}
