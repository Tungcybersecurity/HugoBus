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
    public class StudentBUS
    {
        public DataTable duLieu()
        {
            return (new StudentDAO().doDuLieu());
        }

        public Parents thongTinChiTietHocSinh(string tendangnhap)
        {
            return (new StudentDAO().thongTinChiTietHocSinh(tendangnhap)); 
        }

        public bool xoaHocSinh(int id)
        {
            return (new StudentDAO().xoaHocSinh(id));
        }
        public DataTable duLieuTimKiem(string loai,string value)
        {
            return (new StudentDAO().doDuLieuTimKiem(loai, value));
        }
    }
}
