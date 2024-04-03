using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.classes;

namespace Dal.interfaces
{
    public interface IEmployeeDal
    {
        public List<EmployeeDto> GetAll();
        public EmployeeDto GetById(int id);
        public int AddEmployee(EmployeeDto newEmployee);
        public int UpdateEmployee(EmployeeDto updateEmployee);
        public int DeleteEmployee(int EmployeeId);
    }
}
