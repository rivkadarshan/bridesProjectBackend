using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.classes
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePhone { get; set; }
        public DateTime? StartingWorkDate { get; set; }
    }
}
