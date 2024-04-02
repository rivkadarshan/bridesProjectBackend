using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bll.interfaces;
using Dal.interfaces;
using Dto.classes;

namespace Bll.classes
{
    public class BridejewelryBll : IBridejewelryBll
    {
        IBridejewelryDal dal;

        public BridejewelryBll(IBridejewelryDal _dalBridejewelryDal)
        {
            dal = _dalBridejewelryDal;
        }

        public List<BridejewelryDto> GetAll()
        {
            return dal.GetAll();
        }

        public BridejewelryDto GetById(int id)
        {
            return dal.GetById(id);
        }

        public List<BridejewelryDto> GetJewelryAccordingToBrideId(int brideId)
        {
            return dal.GetJewelryAccordingToBrideId(brideId);
        }

        public int AddBrideJewelry(BridejewelryDto newBridejewelry)
        {
            return dal.AddBrideJewelry(newBridejewelry);
        }   
        
        public int UpdateBrideJewelry(int jewelryId, int brideId)
        {
            return dal.UpdateBrideJewelry(jewelryId, brideId);
        }

        public int DeleteBrideJewelry(int brideJewelryId)
        {
            return dal.DeleteBrideJewelry(brideJewelryId);
        }

        public int UpdateListBrideJewelry(List<BridejewelryDto> brideJewrlryList)
        {
            return dal.UpdateListBrideJewelry(brideJewrlryList);
        }
    }
}
