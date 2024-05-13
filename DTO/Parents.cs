using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Parents
    {
        private string tendangnhap;
        private string ho;
        private string ten;
        private string gioitinh;
        private string ngaysinh;
        private string email;
        private string sdt;

        public Parents() { }

        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
