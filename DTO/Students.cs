using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Students
    {
        private int idhocsinh;
        private string ho;
        private string ten;
        private string gioitinh;
        private string ngaysinh;
        private string truong;
        private string lop;
        private string tendangnhap;

        public Students() { }
        public int Idhocsinh { get => idhocsinh; set => idhocsinh = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Truong { get => truong; set => truong = value; }
        public string Lop { get => lop; set => lop = value; }
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
    }
}
