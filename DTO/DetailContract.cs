using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DetailContract
    {
        private int idchitiet;
        private int idhopdong;
        private int thutrongtuan;
        private string buoi;

        public DetailContract() { }

        public int Idchitiet { get => idchitiet; set => idchitiet = value; }
        public int Idhopdong { get => idhopdong; set => idhopdong = value; }
        public int Thutrongtuan { get => thutrongtuan; set => thutrongtuan = value; }
        public string Buoi { get => buoi; set => buoi = value; }
    }
}
