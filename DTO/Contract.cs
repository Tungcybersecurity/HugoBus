using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Contract
    {
        private int idhopdong;
        private int idhocsinh;
        private string ngaytaohopdong;
        private string ngaybatdauhopdong;
        private string ngaycapnhattrangthai;
        private int idtramdon;
        private int idtruong;
        private int idtrangthai;


        public Contract() { }

        public int Idhopdong { get => idhopdong; set => idhopdong = value; }
        public int Idhocsinh { get => idhocsinh; set => idhocsinh = value; }
        public string Ngaytaohopdong { get => ngaytaohopdong; set => ngaytaohopdong = value; }
        public string Ngaybatdauhopdong { get => ngaybatdauhopdong; set => ngaybatdauhopdong = value; }
        public string Ngaycapnhattrangthai { get => ngaycapnhattrangthai; set => ngaycapnhattrangthai = value; }
        public int Idtramdon { get => idtramdon; set => idtramdon = value; }
        public int Idtruong { get => idtruong; set => idtruong = value; }
        public int Idtrangthai { get => idtrangthai; set => idtrangthai = value; }
    }
}
