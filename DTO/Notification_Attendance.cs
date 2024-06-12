using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Notification_Attendance
    {
        private int idthongbao;
        private int iddiemdanh;

        public Notification_Attendance() { }

        public int Idthongbao { get => idthongbao; set => idthongbao = value; }
        public int Iddiemdanh { get => iddiemdanh; set => iddiemdanh = value; }
    }
}
