using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.interfaces;
using Dto.classes;
using Dal.Models;
using System.Drawing;

namespace Dal.converters
{
    public class BridejewelryConvert
    {
        public static BridejewelryDto ToDto(BridejewelryTbl j)
        {

            return new BridejewelryDto
            {
                Bridejewelryid=j.Bridejewelryid,
                Brideid=j.Brideid,
                Jewelryid= j.Jewelryid,
                Budget = j.Budget,
                Sumtopay = j.Sumtopay,
                Color = j.Color,
                DescriptionBridejewelry= j.DescriptionBridejewelry,
                Ischoose = j.Ischoose,
                Jewelryname = j.Jewelryname,
            };
        }
        public static BridejewelryTbl ToDal(BridejewelryDto j)
        {
            return new BridejewelryTbl
            {
                Bridejewelryid=j.Bridejewelryid,
                Brideid=j.Brideid,
                Jewelryid = j.Jewelryid,
                Budget= j.Budget,
                Sumtopay = j.Sumtopay,
                Color = j.Color,
                DescriptionBridejewelry=j.DescriptionBridejewelry,
                Ischoose = j.Ischoose,
                Jewelryname = j.Jewelryname,
            };
        }

        public static List<BridejewelryTbl> ToLDal(List<BridejewelryDto> lc)
        {
            List<BridejewelryTbl> newl = new List<BridejewelryTbl>();
            foreach (var item in lc)
            {
                newl.Add(ToDal(item));
            }
            return newl;
        }
        public static List<BridejewelryDto> ToLDto(List<BridejewelryTbl> lc)
        {
            List<BridejewelryDto> newl = new List<BridejewelryDto>();
            foreach (var item in lc)
            {
                newl.Add(ToDto(item));
            }
            return newl;
        }
    }
}
