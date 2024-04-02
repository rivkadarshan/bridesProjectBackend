using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.classes;

namespace Bll.interfaces
{
    public interface ICustomerBll
    {
        public List<CustomerDto> GetAll();
        public CustomerDto GetById(int id);
        public int AddCustomer(CustomerDto newCustomer);
        public int UpdateCustomer(CustomerDto updateCustomer);
        public int DeleteCustomer(int customerId);
    }
}
