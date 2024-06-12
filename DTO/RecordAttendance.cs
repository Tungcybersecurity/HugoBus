using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RecordAttendance
    {
        private int iddiemdanh;
        private int idphancong;
        private string thoigiandiemdanh;
        private int idtrangthaidiemdanh;
        public RecordAttendance() { }

        public int Iddiemdanh { get => iddiemdanh; set => iddiemdanh = value; }
        public int Idphancong { get => idphancong; set => idphancong = value; }
        public string Thoigiandiemdanh { get => thoigiandiemdanh; set => thoigiandiemdanh = value; }
        public int Idtrangthaidiemdanh { get => idtrangthaidiemdanh; set => idtrangthaidiemdanh = value; }
    }
}
