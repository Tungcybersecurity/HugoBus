using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BUS
{
    public class EmployeeDriverBus
    {
        public DataTable getDuLieu()
        {
            return (new EmployeeDriverDAO().doDulieu());
        }

        public Boolean xoaTaiXeById(int id)
        {
            return(new EmployeeDriverDAO().xoa(id));
        }

        public Boolean themTaixe(Driver driver)
        {
            return (new EmployeeDriverDAO().them(driver));
        }
        public Driver getTextfield(int id)
        {
            return (new EmployeeDriverDAO().doTextField(id));
        }
        public bool sua(Driver driver)
        {
            return (new EmployeeDriverDAO().sua(driver));
        }
        public DataTable getSearch(string loai,string value)
        {
            return (new EmployeeDriverDAO().doDuLieuTimKiem(loai,value));   
        }
    }
}
