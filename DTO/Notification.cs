using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Notification
    {
        private int idthongbao;
        private string tenthongbao;
        private int idloai;
        public Notification() { }

        public int Idthongbao { get => idthongbao; set => idthongbao = value; }
        public string Tenthongbao { get => tenthongbao; set => tenthongbao = value; }
        public int Idloai { get => idloai; set => idloai = value; }
    }
}
