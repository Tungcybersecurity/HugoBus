using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Driver
    {
        private int idtaixe;
        private string ho;
        private string ten;
        private string gioitinh;
        private string ngaysinh;
        private string cccd;
        private string email;
        private string sdt;
        public Driver() { }

        public int Idtaixe { get => idtaixe; set => idtaixe = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
