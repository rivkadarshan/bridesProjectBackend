using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.converters;
using Dal.interfaces;
using Dal.Models;
using Dto.classes;

namespace Dal.classes
{
    public class BrideFunc : IBrideDal
    {
        ProjectBridesContext db;
        public BrideFunc(ProjectBridesContext _db)
        {
            db = _db;     
        }
        
        public List<BrideDto> GetAll()
        {
            return BrideConvert.ToLDto(db.BrideTbls.ToList());
        }

        public BrideDto GetById(int id)
        {
            try
            {
                var x = db.BrideTbls.First(x => x.Brideid == id);
                return BrideConvert.ToDto(x);
            }
            catch
            {
                return null;
            }
        }
        public int AddBride(BrideDto newBride)
        {
            ProjectBridesContext db = new ProjectBridesContext();
            db.BrideTbls.Add(BrideConvert.ToDal(newBride));
            int x =db.SaveChanges();
            return x;
        }

        public int DeleteBride(int _id)
        {
            
                try
                {
                var recordsToDelete = db.BridejewelryTbls.Where(b => b.Brideid == _id);
                if (recordsToDelete != null)
                {
                    db.BridejewelryTbls.RemoveRange(recordsToDelete);
                    int x = db.SaveChanges();
                }
                    var q2 = db.BrideTbls.FirstOrDefault(b => b.Brideid == _id);
                    if (q2 == null)
                    return -1;
                    db.BrideTbls.Remove(q2);
                    int y = db.SaveChanges();
                return y;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
        }

        public int UpdateBride(BrideDto updateBride)
        {
            BrideTbl bride =db.BrideTbls.First(x=>x.Brideid==updateBride.Brideid);
            bride.Bridename = updateBride.Bridename;
            return 1;
        }
    }
}
