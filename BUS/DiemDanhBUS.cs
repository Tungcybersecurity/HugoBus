using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BUS
{
    public class DiemDanhBUS
    {
        public int getIDDiemDanhByID(string idPhanCong)
        {
            return (new DiemDanhDAO().getIDDiemDanhMoiNhatByID(idPhanCong));
        }
        public DataTable getThongTinDiemDanhByID(string idDiemDanh)
        {
            return (new DiemDanhDAO().getThongTinDiemDanhByID(idDiemDanh));
        }
        public int xoaDiemDanh(string idDiemDanh)
        {
            return (new DiemDanhDAO().xoaDiemDanh(idDiemDanh));
        }
        public int themDiemDanh(string idPhanCong, string thoigian, string idTinhTrang)
        {
            return (new DiemDanhDAO().themDiemDanh(idPhanCong,thoigian,idTinhTrang));
        }
        public DataTable doDuLieu(int idPhanCong)
        {
            return (new DiemDanhDAO().doDuLieu(idPhanCong));
        }
    }
}
