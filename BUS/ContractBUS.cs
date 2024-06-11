using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ContractBUS
    {
        public DataTable duLieu()
        {
            return (new ContractDAO().doDuLieu());
        }
        public DataTable getHopDongHieuLuc()
        {
            return (new ContractDAO().getHopDongHieuLuc());
        }
        public DataTable getChiTietHopDongByID(string idHopDong)
        {
            return (new ContractDAO().getChiTietHopDongByID(idHopDong));
        }

        public int xoaHopDong(string idHopDong)
        {
            return (new ContractDAO().deleteHopDong(idHopDong));
        }

        public int updateTrangThai(string idHopDong, int idTrangThai)
        {
            return (new ContractDAO().updateHopDong(idHopDong, idTrangThai));
        }
    }
}
