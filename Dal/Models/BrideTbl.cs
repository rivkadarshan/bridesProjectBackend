using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class BrideTbl
{
    public int Brideid { get; set; }

    public string? Bridename { get; set; }

    public string? Bridephone { get; set; }

    public string? Groomname { get; set; }

    public string? Groomphone { get; set; }

    public DateTime? Weddingdate { get; set; }

    public DateTime Brideinsertdate { get; set; }

    public int? Debt { get; set; }

    public string? DescriptionBride { get; set; }

    public int? Paid { get; set; }
    public string? Address { get; set; }

    public virtual ICollection<BridejewelryTbl> BridejewelryTbls { get; set; } = new List<BridejewelryTbl>();
}
