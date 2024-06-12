using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class School
    {
        private int idtruong;
        private string tentruong;
        private string phuong;
        public School() { }

        public int Idtruong { get => idtruong; set => idtruong = value; }
        public string Tentruong { get => tentruong; set => tentruong = value; }
        public string Phuong { get => phuong; set => phuong = value; }
    }
}
