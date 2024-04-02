using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.classes;

namespace Bll.interfaces
{
    public interface ICorrectionBll
    {
        public List<CorrectionDto> GetAll();
        public CorrectionDto GetById(int id);
        public int AddCorrection(CorrectionDto newCorrection);
        public int UpdateCorrection(CorrectionDto updateCorrection);
        public int DeleteCorrection(int correctionId);
    }
}
