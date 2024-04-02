using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bll.interfaces;
using Dal.interfaces;
using Dto.classes;

namespace Bll.classes
{
    public class EmployeeBll : IEmployeeBll
    {
        IEmployeeDal dal;

        public EmployeeBll(IEmployeeDal _dal)
        {
            dal = _dal;
        }
        public List<EmployeeDto> GetAll()
        {
            return dal.GetAll();
        }

        public EmployeeDto GetById(int id)
        {
            return dal.GetById(id);
        }
        public int AddEmployee(EmployeeDto newEmployee)
        {
            return dal.AddEmployee(newEmployee);
        }

        public int DeleteEmployee(int EmployeeId)
        {
            return dal.DeleteEmployee(EmployeeId);
        }

        public int UpdateEmployee(EmployeeDto updateEmployee)
        {
            return dal.UpdateEmployee(updateEmployee);
        }
    }
}
