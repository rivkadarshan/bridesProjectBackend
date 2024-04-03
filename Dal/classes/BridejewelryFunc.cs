using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Dal.converters;
using Dal.interfaces;
using Dal.Models;
using Dto.classes;

namespace Dal.classes
{
    public class BridejewelryFunc : IBridejewelryDal
    {

        ProjectBridesContext db;
        public BridejewelryFunc(ProjectBridesContext _db)
        {
            db = _db;
        }

        public List<BridejewelryDto> GetAll()
        {
            return BridejewelryConvert.ToLDto(db.BridejewelryTbls.ToList());
        }

        public BridejewelryDto GetById(int id)
        {
            try
            {
                var x = db.BridejewelryTbls.First(x => x.Bridejewelryid == id);
                return BridejewelryConvert.ToDto(x);
            }
            catch
            {
                return null;
            }
        }
        public List<BridejewelryDto> GetJewelryAccordingToBrideId(int brideId)
        {
            try
            {
                var result = db.BridejewelryTbls
                    .Where(x => x.Brideid == brideId)
                    .Select(x => BridejewelryConvert.ToDto(x))
                    .ToList();

                return result;
            }
            catch
            {
                return null;
            }
        }
        public int AddBrideJewelry(BridejewelryDto newBridejewelry)
        {
            ProjectBridesContext db = new ProjectBridesContext();
            db.BridejewelryTbls.Add(BridejewelryConvert.ToDal(newBridejewelry));
            JewelryDto newS = new JewelryDto();
            int x = db.SaveChanges();
            return x;
        }

        public int UpdateBrideJewelry(int jewelryId, int brideId)
        {
            throw new NotImplementedException();
        }

        public int DeleteBrideJewelry(int brideJewelryId)
        {
            try
            {
                var q1 = db.BridejewelryTbls.FirstOrDefault(b => b.Bridejewelryid == brideJewelryId);
                if (q1 == null)
                    return -1;
                db.BridejewelryTbls.Remove(q1);
                int x = db.SaveChanges();
                return x;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int UpdateListBrideJewelry(List<BridejewelryDto> brideJewelryList)
        {
            try
            {
                foreach (var brideJewelryDto in brideJewelryList)
                {
                    var brideJewelry = db.BridejewelryTbls.FirstOrDefault(b => b.Bridejewelryid == brideJewelryDto.Bridejewelryid);
                    if (brideJewelry == null)
                    {
                        continue;
                    }
                    brideJewelry.Ischoose = brideJewelryDto.Ischoose; // Update other properties as needed
                }
                db.SaveChanges();

                return 1; // Indicate success
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating bride jewelry list: {ex.Message}");
            }
        }

    }
}
