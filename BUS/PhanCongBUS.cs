using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Org.BouncyCastle.Asn1.Mozilla;
namespace BUS
{
    public class PhanCongBUS
    {
        public int xoaPhanCong2(string idHopDong)
        {
            return new PhanCongDAO().xoaPhanCong2(idHopDong);
        }
        public int themPhanCong(string idChiTiet, string idChuyen, string ngayDuaDon)
        {
            return (new PhanCongDAO().themPhanCong(idChiTiet, idChuyen, ngayDuaDon));
        }
        public int xoaPhanCong(string idPhanCong)
        {
            return (new PhanCongDAO().xoaPhanCong(idPhanCong));
        }
        public int suaPhanCong(string idChuyen, string ngayDuaDon, string idPhanCong)
        {
            return (new PhanCongDAO().suaPhanCong(idChuyen, ngayDuaDon, idPhanCong));
        }
        public int tongGheByIdChuyen_NgayDuaDon(string idChuyen, string NgayDuaDon)
        {
            return (new PhanCongDAO().tongGheByIdChuyen_NgayDuaDon(idChuyen, NgayDuaDon));
        }
        public int getIDTuyenDuong(string TruongDen, string PhuongDon)
        {
            return (new PhanCongDAO().getIDTuyenDuong(TruongDen, PhuongDon));
        }
        public DataTable duLieuChuaPhanCong()
        {
            return (new PhanCongDAO().doDuLieuChuaPhanCong());
        }
        public DataTable duLieu()
        {
            return (new PhanCongDAO().doDuLieu());
        }
    }
}
