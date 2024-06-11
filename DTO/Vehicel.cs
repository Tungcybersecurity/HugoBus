using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Vehicel
    {
        private int idxe;
        private string bienso;
        private int soghe;
        public Vehicel() { }

        public int Idxe { get => idxe; set => idxe = value; }
        public string Bienso { get => bienso; set => bienso = value; }
        public int Soghe { get => soghe; set => soghe = value; }
    }
}
