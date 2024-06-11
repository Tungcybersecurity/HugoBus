using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThongBaoBUS
    {
        public int themThongBaoHopDong(string TenThongBao, string loai, string idHopDong)
        {
            return (new ThongBaoDAO().themThongBaoHopDong(TenThongBao,loai,idHopDong));
        }

        public int themThongBaoDiemDanh(string TenThongBao, string loai, string idDiemDanh)
        {
            return (new ThongBaoDAO().themThongBaoDiemDanh(TenThongBao, loai, idDiemDanh));
        }
    }
}
