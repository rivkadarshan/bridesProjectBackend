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
    public class CorrectionBll : ICorrectionBll
    {
        ICorrectionDal dal;

        public CorrectionBll(ICorrectionDal _dal)
        {
            dal = _dal;
        }
        public int AddCorrection(CorrectionDto newBridejewelry)
        {
           return dal.AddCorrection(newBridejewelry);
        }

        public int DeleteCorrection(int brideJewelryId)
        {
            return dal.DeleteCorrection(brideJewelryId);
        }

        public List<CorrectionDto> GetAll()
        {
            return dal.GetAll();
        }

        public CorrectionDto GetById(int id)
        {
            return dal.GetById(id); 
        }

        public int UpdateCorrection(CorrectionDto updateCurrection)
        {
            return dal.UpdateCorrection(updateCurrection);
        }
    }
}
