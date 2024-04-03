using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    public class Notes
    {
        public int NoteId { get; set; }
        public int CustomerId { get; set; }
        public int TitleId { get; set; }
        public int SupplierId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Title Title { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
