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
    public class CustomerBll : ICustomerBll
    {
        ICustomerDal dal;

        public CustomerBll(ICustomerDal _dal)
        {
            dal = _dal;
        }
        public int AddCustomer(CustomerDto newCustomer)
        {
            return dal.AddCustomer(newCustomer);
        }

        public int DeleteCustomer(int customerId)
        {
            return dal.DeleteCustomer(customerId);
        }

        public List<CustomerDto> GetAll()
        {
            return dal.GetAll();
        }

        public CustomerDto GetById(int id)
        {
            return dal.GetById(id);
        }

        public int UpdateCustomer(CustomerDto updateCustomer)
        {
            return dal.UpdateCustomer(updateCustomer);
        }
    }
}
