using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.converters;
using Dal.interfaces;
using Dal.Models;
using Dto.classes;

namespace Dal.classes
{
    public class EmployeeFunc : IEmployeeDal
    {
        ProjectBridesContext db;
        public EmployeeFunc(ProjectBridesContext _db)
        {
            db = _db;
        }

        public List<EmployeeDto> GetAll()
        {
            var employees = db.Employees.ToList();
            if (employees == null)
            {
                return new List<EmployeeDto>();
            }
            else
            {
                return EmployeeConvert.ToLDto(employees);
            }
        }


        public EmployeeDto GetById(int id)
        {
            try
            {
                var x = db.Employees.First(x => x.EmployeeId == id);
                return EmployeeConvert.ToDto(x);
            }
            catch
            {
                return null;
            }
        }

        public int AddEmployee(EmployeeDto newEmployee)
        {
            using (ProjectBridesContext db = new ProjectBridesContext())
            {
                db.Employees.Add(EmployeeConvert.ToDal(newEmployee));
                db.SaveChanges();
                return db.Employees.OrderByDescending(c => c.EmployeeId).FirstOrDefault()?.EmployeeId ?? -1;
            }
        }

        public int DeleteEmployee(int EmployeeId)
        {
            throw new NotImplementedException();
        }

        public int UpdateEmployee(EmployeeDto updateEmployee)
        {
            throw new NotImplementedException();
        }
    }
}
