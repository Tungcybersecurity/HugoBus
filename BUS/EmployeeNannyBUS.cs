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
    public class EmployeeNannyBUS
    {
        public DataTable getDuLieu()
        {
            return (new EmployeeNannyDAO().doDulieu());
        }

        public Boolean xoaNannyById(int id)
        {
            return (new EmployeeNannyDAO().xoa(id));
        }

        public Boolean themNanny(Nanny nanny)
        {
            return (new EmployeeNannyDAO().them(nanny));
        }

        public Nanny getTextfield(int id)
        {
            return (new EmployeeNannyDAO().doTextField(id));
        }

        public bool sua(Nanny nanny)
        {
            return (new EmployeeNannyDAO().sua(nanny));
        }
        public DataTable getSearch(string loai, string value)
        {
            return (new EmployeeNannyDAO().doDuLieuTimKiem(loai, value));
        }
    }
}
