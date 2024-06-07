using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GUI.Employee
{
    public class Kiemtra
    {
        public Kiemtra() { }
        public bool kiemTraTen(string name)
        {
            string pattern = @"^[A-Za-zÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơưÀÁẢÃẠẦẤẪẨẬẰẮẲẴẶÈÉẺẼẸỀẾỂỄỆÌÍỈĨỊÒÓỎÕỌỒỐỔỖỘỜỚỞỠỢÙÚỦŨỤỪỨỬỮỰỲÝỶỸỴỳýỷỹỵƯửữựƯƯăạảãâấầẩẫậắằẳẵặéèẻẽẹêềếểễệíìỉĩịóòỏõọôồốổỗộớờởỡợúùủũụưứừửữựýỳỷỹỵ\s]+$";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(name))
            {
                return true;
            }
            else { 
                return false;
            }

        }

        public bool kiemTraDiaChi(string address)
        {
            string pattern = @"^[A-Za-z0-9ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơưÀÁẢÃẠẦẤẪẨẬẰẮẲẴẶÈÉẺẼẸỀẾỂỄỆÌÍỈĨỊÒÓỎÕỌỒỐỔỖỘỜỚỞỠỢÙÚỦŨỤỪỨỬỮỰỲÝỶỸỴỳýỷỹỵƯửữựƯƯăạảãâấầẩẫậắằẳẵặéèẻẽẹêềếểễệíìỉĩịóòỏõọôồốổỗộớờởỡợúùủũụưứừửữựýỳỷỹỵ\s,.\/\\-]+$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(address))
            {
                return true;
            }
            else {
                return false;
            }
        }

        public bool kiemTraSDT(string sdt)
        {
            string pattern = @"^0[35789]\d{8}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(sdt))
            {
                return true;
            }
            else {
                return false;
            }
        }

        public bool kiemTraEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool kiemTraCCCD(string cccd)
        {
            string pattern = @"^\d{9,12}$"; // Chuỗi gồm 9-12 ký tự số

            // Kiểm tra xem chuỗi nhập vào có khớp với định dạng không
            return Regex.IsMatch(cccd, pattern);
        }

    }
}
