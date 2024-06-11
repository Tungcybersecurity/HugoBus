using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Station
    {
        private int idtram;
        private string tentram;
        private string phuong;

        public Station() { }

        public int Idtram { get => idtram; set => idtram = value; }
        public string Tentram { get => tentram; set => tentram = value; }
        public string Phuong { get => phuong; set => phuong = value; }
    }

   
}
