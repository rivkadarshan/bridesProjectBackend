using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class BridejewelryTbl
{
    public int Bridejewelryid { get; set; }

    public int Brideid { get; set; }

    public int Jewelryid { get; set; }

    public int? Budget { get; set; }

    public int? Sumtopay { get; set; }

    public string? Color { get; set; }

    public string? DescriptionBridejewelry { get; set; }
    public bool? Ischoose { get; set; }
    public string? Jewelryname { get; set; }

    public virtual BrideTbl Bride { get; set; } = null!;

    //public virtual JewelryTbl Jewelry { get; set; } = null!;
}
