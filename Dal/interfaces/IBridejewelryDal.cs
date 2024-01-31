using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.classes;

namespace Dal.interfaces
{
    public interface IBridejewelryDal
    {
        public List<BridejewelryDto> GetAll();
        public BridejewelryDto GetById(int id);
        public List<BridejewelryDto> GetJewelryAccordingToBrideId(int brideId);
        public int AddBrideJewelry(BridejewelryDto newBridejewelry);
        public int UpdateBrideJewelry(int jewelryId, int brideId);
        public int DeleteBrideJewelry(int brideJewelryId);
    }
}
