using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class ChuyenBUS
    {
        public DataTable doDuLieu()
        {
            return (new ChuyenDAO().doDuLieu());
        }
        public DataTable getIDChuyenByInfor(int idTuyen, int ThuHoatDong, int BuoiHoatDong)
        {
            return (new ChuyenDAO().getIDChuyenByInformation(idTuyen,ThuHoatDong,BuoiHoatDong));
        }
    }
}
