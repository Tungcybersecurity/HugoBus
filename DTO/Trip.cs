using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Trip
    {
        private int idchuyen;
        private int idtaixe;
        private int idbaomau;
        private int thuhoatdong;
        private int buoihoatdong;
        private int idxe;
        private int idtuyenduong;

        public Trip() { }

        public int Idchuyen { get => idchuyen; set => idchuyen = value; }
        public int Idtaixe { get => idtaixe; set => idtaixe = value; }
        public int Idbaomau { get => idbaomau; set => idbaomau = value; }
        public int Thuhoatdong { get => thuhoatdong; set => thuhoatdong = value; }
        public int Buoihoatdong { get => buoihoatdong; set => buoihoatdong = value; }
        public int Idxe { get => idxe; set => idxe = value; }
        public int Idtuyenduong { get => idtuyenduong; set => idtuyenduong = value; }
    }
}
