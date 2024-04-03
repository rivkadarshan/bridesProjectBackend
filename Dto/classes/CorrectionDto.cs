using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.classes
{
    public class CorrectionDto
    {
        public int CorrectionId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeIdTakeCorrections { get; set; }
        public int EmployeeIdDeliverMessage { get; set; }
        public DateTime ReceivingDate { get; set; }
        public int? GoldsmithId { get; set; }
        public bool IsDeliveredMessage { get; set; }
        public string ForHoeDeliveredMessage { get; set; }
        public string CorrectionDescription { get; set; }
        public bool IsReady { get; set; }

        //public virtual Customer Customer { get; set; }
        //public virtual ICollection<Task> Tasks { get; set; }
    }
}
