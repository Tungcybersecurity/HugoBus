using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AssignTranportation
    {
        private int idphancong;
        private int idchitiet;
        private int idchuyen;
        private string ngayduadon;
      public AssignTranportation() { }

        public int Idphancong { get => idphancong; set => idphancong = value; }
        public int Idchitiet { get => idchitiet; set => idchitiet = value; }
        public int Idchuyen { get => idchuyen; set => idchuyen = value; }
        public string Ngayduadon { get => ngayduadon; set => ngayduadon = value; }
    }
}
