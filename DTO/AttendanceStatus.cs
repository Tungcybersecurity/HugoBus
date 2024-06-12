using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AttendanceStatus
    {
        private int idtinhtrangdiemdanh;
        private string tinhtrang;
        public AttendanceStatus() { }

        public int Idtinhtrangdiemdanh { get => idtinhtrangdiemdanh; set => idtinhtrangdiemdanh = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
    }
}
