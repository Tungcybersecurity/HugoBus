using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TypeOfNotification
    {
        private int idloai;
        private string tenloai;

        public TypeOfNotification() { }

        public int Idloai { get => idloai; set => idloai = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }
    }
}
