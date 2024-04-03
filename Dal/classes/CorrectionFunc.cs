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
    public class CorrectionFunc : ICorrectionDal
    {
        ProjectBridesContext db;
        public CorrectionFunc(ProjectBridesContext _db)
        {
            db = _db;
        }
        public List<CorrectionDto> GetAll()
        {
            return CorrectionConvert.ToLDto(db.Corrections.ToList());
        }
        public CorrectionDto GetById(int id)
        {
            try
            {
                var x = db.Corrections.First(x => x.CorrectionId == id);
                return CorrectionConvert.ToDto(x);
            }
            catch
            {
                return null;
            }
        }

        public int AddCorrection(CorrectionDto newCorrection)
        {
            using (ProjectBridesContext db = new ProjectBridesContext())
            {
                db.Corrections.Add(CorrectionConvert.ToDal(newCorrection));
                db.SaveChanges();
                return db.Corrections.OrderByDescending(c=>c.CorrectionId).FirstOrDefault()?.CorrectionId ?? -1;
            }
        }

        public int DeleteCorrection(int brideJewelryId)
        {
            throw new NotImplementedException();
        }
       
        public int UpdateCorrection(CorrectionDto updateCorrection)
        {
            throw new NotImplementedException();
        }
    }
}
