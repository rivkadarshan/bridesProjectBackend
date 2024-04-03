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
    public class EmployeeControler : Controller
    {
        IEmployeeBll bll;
        public EmployeeControler(IEmployeeBll _bll)
        {
            bll = _bll;
        }
        [HttpGet("GetAll")]
        public ActionResult<List<EmployeeDto>> GetAll()
        {
            List<EmployeeDto> x = bll.GetAll();
            return Ok(bll.GetAll());
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<List<EmployeeDto>> GetById(int id)
        {
            return Ok(bll.GetById(id));
        }
        [HttpPost("AddCustomer")]
        public ActionResult AddEmployee(EmployeeDto newEmployee)
        {
            int x = bll.AddEmployee(newEmployee);
            if (x == -1)
                return NotFound();
            return Ok(x);
        }
        [HttpPut("UpdateCustomer")]
        public ActionResult UpdateEmployee(EmployeeDto updateEmployee)
        {
            int x = bll.UpdateEmployee(updateEmployee);
            if (x == -1)
                return NotFound();
            return Ok(x);
        }
        [HttpDelete("DeleteEmployee/{DeleteEmployeeId}")]
        public ActionResult DeleteEmployee(int employeeId)
        {
            int x = bll.DeleteEmployee(employeeId);
            if (x == -1)
                return NotFound();
            return Ok();
        }

    }
}
