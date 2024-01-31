using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.classes
{
    public class JewelryDto
    {
        public int Jewelryid { get; set; }

        public string? Jewelryname { get; set; }

        public string? Feature { get; set; }

        //public virtual ICollection<BridejewelryTbl> BridejewelryTbls { get; set; } = new List<BridejewelryTbl>();
    }
}
