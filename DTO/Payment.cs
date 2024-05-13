using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Payment
    {
        private int idthanhtoan;
        private string ngaythanhtoan;
        private int sotiencanthanhtoan;
        private string phuongthucthanhtoan;
        private int idhopdong;
        public Payment() { }

        public int Idthanhtoan { get => idthanhtoan; set => idthanhtoan = value; }
        public string Ngaythanhtoan { get => ngaythanhtoan; set => ngaythanhtoan = value; }
        public int Sotiencanthanhtoan { get => sotiencanthanhtoan; set => sotiencanthanhtoan = value; }
        public string Phuongthucthanhtoan { get => phuongthucthanhtoan; set => phuongthucthanhtoan = value; }
        public int Idhopdong { get => idhopdong; set => idhopdong = value; }
    }
}
