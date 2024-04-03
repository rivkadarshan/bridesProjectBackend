using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bll.interfaces;
using Dto.classes;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerControler : Controller
    {
        ICustomerBll bll;
        public CustomerControler(ICustomerBll _bll)
        {
            bll = _bll;
        }
        [HttpGet("GetAll")]
        public ActionResult<List<CustomerDto>> GetAll()
        {
            List<CustomerDto> x = bll.GetAll();
            return Ok(bll.GetAll());
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<List<CustomerDto>> GetById(int id)
        {
            return Ok(bll.GetById(id));
        }
        [HttpPost("AddCustomer")]
        public ActionResult AddCustomer(CustomerDto newCustomer)
        {
            int x = bll.AddCustomer(newCustomer);
            if (x == -1)
                return NotFound();
            return Ok(x);
        }
        [HttpPut("UpdateCustomer")]
        public ActionResult UpdateCustomer(CustomerDto updateCustomer)
        {
            int x = bll.UpdateCustomer(updateCustomer);
            if (x == -1)
                return NotFound();
            return Ok(x);
        }
        [HttpDelete("DeleteCustomer/{DeleteCustomerId}")]
        public ActionResult DeleteCustomer(int customerId)
        {
            int x = bll.DeleteCustomer(customerId);
            if (x == -1)
                return NotFound();
            return Ok();
        }

    }
}
