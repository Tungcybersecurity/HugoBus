using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ContractStatus
    {
        private int idtrangthai;
        private string tentrangthai;
        public ContractStatus() { }

        public int Idtrangthai { get => idtrangthai; set => idtrangthai = value; }
        public string Tentrangthai { get => tentrangthai; set => tentrangthai = value; }
    }
}
