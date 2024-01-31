using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.classes;

namespace Dal.interfaces
{
    public interface IBrideDal
    {
        public List<BrideDto> GetAll();
        public BrideDto GetById(int id);
        public int AddBride(BrideDto newBride);
        public int UpdateBride(BrideDto updateBride);
        public int DeleteBride(int _id);

    }
}
