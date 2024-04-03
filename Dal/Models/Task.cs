using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskDescription { get; set; }
        public bool IsDone { get; set; }
        public int CorrectionId { get; set; }

        public virtual Correction Correction { get; set; }
    }
}
