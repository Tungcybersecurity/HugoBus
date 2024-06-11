using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PaymentBUS
    {
        public DataTable duLieu()
        {
            return (new PaymentDAO().doDuLieu());
        }
        public DataTable getTongTungThang()
        {
            return new PaymentDAO().getTongTungThang();
        }

        public DataTable getTongTungQuy()
        {
            return new PaymentDAO().getTongTungQuy();
        }

        public DataTable getTongTungNam()
        {
            return new PaymentDAO().getTongTungNam();
        }

        public DataTable getTTThang()
        {
            return new PaymentDAO().getTTThang();
        }

        public DataTable getTTQuy()
        {
            return new PaymentDAO().getTTQuy();
        }

        public DataTable getTTNam()
        {
            return new PaymentDAO().getTTNam();
        }

        public DataTable getIDHopDong()
        {
            return new PaymentDAO().getIDHopDong();
        }

        public int themThanhToan(string idHopDong, int soTienThanhToan, string ngayThanhToan, string phuongThucThanhToan)
        {
            return new PaymentDAO().themThanhToan(idHopDong, soTienThanhToan, ngayThanhToan, phuongThucThanhToan);
        }

        public int suaThanhToan(string idHopDong, int soTienThanhToan, string ngayThanhToan, string phuongThucThanhToan, string idThanhToan)
        {
            return new PaymentDAO().suaThanhToan(idHopDong, soTienThanhToan, ngayThanhToan, phuongThucThanhToan, idThanhToan);
        }

        public int xoaThanhToan(string idThanhToan)
        {
            return new PaymentDAO().xoaThanhToan(idThanhToan);
        }

        public long tongThongKe(string NgayBatDau, string NgayKetThuc)
        {
            return new PaymentDAO().tongThongKe(NgayBatDau, NgayKetThuc);
        }

        public DataTable getDataThongKe(string NgayBatDau, string NgayKetThuc)
        {
            return new PaymentDAO().getDataThongKe(NgayBatDau, NgayKetThuc);
        }
    }
}
