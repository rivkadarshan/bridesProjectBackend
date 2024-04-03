using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerDescription { get; set; }

        public virtual ICollection<Correction> Corrections { get; set; }
    }
}
