using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.classes
{
    public class BridejewelryDto
    {
        public int Bridejewelryid { get; set; }

        public int Brideid { get; set; }

        public int Jewelryid { get; set; }
        public string? Jewelryname { get; set; }

        public int? Budget { get; set; }

        public int? Sumtopay { get; set; }
        public bool? Ischoose {  get; set; }
        public string? Color { get; set; }

        public string? DescriptionBridejewelry { get; set; }

        //public virtual BrideTbl Bride { get; set; } = null!;

        //public virtual JewelryTbl Jewelry { get; set; } = null!;
    }
}
