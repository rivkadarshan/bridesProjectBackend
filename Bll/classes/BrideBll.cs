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
    public class BrideBll : IBrideBll
    {
        IBrideDal dal;

        public BrideBll(IBrideDal _dal)
        {
            dal = _dal;
        }
        public List<BrideDto> GetAll()
        {
            return dal.GetAll();
        }

        public BrideDto GetById(int id)
        {
            return dal.GetById(id);
        }

        public int AddBride(BrideDto newBride)
        {
            return dal.AddBride(newBride); 
        }

        public int DeleteBride(int _id)
        {
            return dal.DeleteBride(_id);
        }
    
        public int UpdateBride(BrideDto updateBride)
        {
            return dal.UpdateBride(updateBride);
        }
    }
}
