using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Dal.interfaces;
using Dal.Models;
using Dto.classes;

namespace Dal.converters
{
    public class BrideConvert
    {
        public static BrideDto ToDto(BrideTbl b)
        {
            return new BrideDto
            {
                Brideid = b.Brideid,
                Bridename = b.Bridename,
                Bridephone = b.Bridephone,
                Groomname = b.Groomname,
                Groomphone = b.Groomphone,
                Weddingdate = b.Weddingdate,
                Brideinsertdate = b.Brideinsertdate,
                Debt = b.Debt,
                DescriptionBride = b.DescriptionBride ?? null,
                Paid = b.Paid,
                Address= b.Address,

            };
        }
 
        public static BrideTbl ToDal(BrideDto b)
        {
            return new BrideTbl
            {
                Brideid=b.Brideid,
                Bridename=b.Bridename,
                Bridephone=b.Bridephone,
                Groomname=b.Groomname,
                Groomphone=b.Groomphone,
                Weddingdate=b.Weddingdate,
                Brideinsertdate=b.Brideinsertdate,
                Debt = b.Debt,
                DescriptionBride=b.DescriptionBride ?? null,
                Paid = b.Paid,
                Address= b.Address,
            };
        }
        public static List<BrideTbl> ToLDal(List<BrideDto> lc)
        {
            List<BrideTbl> newl = new List<BrideTbl>();
            foreach (var item in lc)
            {
                newl.Add(ToDal(item));
            }
            return newl;
        }
        public static List<BrideDto> ToLDto(List<BrideTbl> lc)
        {
            List<BrideDto> newl = new List<BrideDto>();
            foreach (var item in lc)
            {
                newl.Add(ToDto(item));
            }
            return newl;
        }

    }
}
