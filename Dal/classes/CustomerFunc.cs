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
    public class CustomerFunc : ICustomerDal
    {
        ProjectBridesContext db;
        public CustomerFunc(ProjectBridesContext _db)
        {
            db = _db;
        }
        public List<CustomerDto> GetAll()
        {
            return CustomerConvert.ToLDto(db.Customers.ToList());
        }

        public CustomerDto GetById(int id)
        {
            try
            {
                var x = db.Customers.First(x => x.CustomerId == id);
                return CustomerConvert.ToDto(x);
            }
            catch
            {
                return null;
            }
        }

        public int AddCustomer(CustomerDto newCustomer)
        {
            using (ProjectBridesContext db = new ProjectBridesContext())
            {
                db.Customers.Add(CustomerConvert.ToDal(newCustomer));
                db.SaveChanges();
                return db.Customers.OrderByDescending(c => c.CustomerId).FirstOrDefault()?.CustomerId ?? -1;
            }
        }

        public int DeleteCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public int UpdateCustomer(CustomerDto updateCustomer)
        {
            throw new NotImplementedException();
        }
    }
}
