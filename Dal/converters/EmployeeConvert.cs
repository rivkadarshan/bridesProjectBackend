using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Models;
using Dto.classes;

namespace Dal.converters
{
    public class EmployeeConvert
    {
        public static EmployeeDto ToDto(Employee c)
        {
            return new EmployeeDto
            {
                EmployeeId = c.EmployeeId,
                EmployeeName = c.EmployeeName,
                EmployeePhone = c.EmployeePhone,
                StartingWorkDate = c.StartingWorkDate,
            };
        }
        public static Employee ToDal(EmployeeDto c)
        {
            return new Employee
            {
                EmployeeId = c.EmployeeId,
                EmployeeName = c.EmployeeName,
                EmployeePhone = c.EmployeePhone,
                StartingWorkDate = c.StartingWorkDate,
            };
        }

        public static List<Employee> ToLDal(List<EmployeeDto> lc)
        {
            List<Employee> newl = new List<Employee>();
            foreach (var item in lc)
            {
                newl.Add(ToDal(item));
            }
            return newl;
        }
        public static List<EmployeeDto> ToLDto(List<Employee> lc)
        {
            List<EmployeeDto> newl = new List<EmployeeDto>();
            foreach (var item in lc)
            {
                newl.Add(ToDto(item));
            }
            return newl;
        }
    }
}

