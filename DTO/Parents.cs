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
        private string diachi;
        private string pathimage;
        public Parents() { }

        public Parents(string tendangnhap, string ho, string ten, string gioitinh, string ngaysinh, string email, string sdt, string diachi, string pathimage)
        {
            this.tendangnhap = tendangnhap;
            this.ho = ho;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
            this.email = email;
            this.sdt = sdt;
            this.diachi = diachi;
            this.pathimage = pathimage;
        }
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Pathimage { get => pathimage; set => pathimage = value; }
    }
}
