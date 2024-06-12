using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Route
    {
        private int idtuyenduong;
        private string tentruongden;
        private string phuongdon;

        public Route() { }

        public int Idtuyenduong { get => idtuyenduong; set => idtuyenduong = value; }
        public string Tentruongden { get => tentruongden; set => tentruongden = value; }
        public string Phuongdon { get => phuongdon; set => phuongdon = value; }
    }
}
