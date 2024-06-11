using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Notification_Contract
    {
        private int idthongbao;
        private int idhopdong;
        public Notification_Contract() { }

        public int Idthongbao { get => idthongbao; set => idthongbao = value; }
        public int Idhopdong { get => idhopdong; set => idhopdong = value; }
    }
}
