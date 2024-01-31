using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.classes;

namespace Bll.interfaces
{
    public interface IBrideBll
    {
        public List<BrideDto> GetAll();
        public BrideDto GetById(int id);
        public int AddBride(BrideDto newBride);
        public int DeleteBride(int _id);
        public int UpdateBride(BrideDto updateBride);
    }
}
