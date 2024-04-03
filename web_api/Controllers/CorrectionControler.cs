using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bll.interfaces;
using Dto.classes;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorrectionControler : Controller
    {
        ICorrectionBll bll;
        public CorrectionControler(ICorrectionBll _bll)
        {
            bll = _bll;
        }
        [HttpGet("GetAll")]
        public ActionResult<List<CorrectionDto>> GetAll()
        {
            List<CorrectionDto> x = bll.GetAll();
            return Ok(bll.GetAll());
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<List<CorrectionDto>> GetById(int id)
        {
            return Ok(bll.GetById(id));
        }
        [HttpPost("AddCorrection")]
        public ActionResult PostaddBrideJewelry(CorrectionDto newBridejewelry)
        {
            int x = bll.AddCorrection(newBridejewelry);
            if (x == -1)
                return NotFound();
            return Ok(x);
        }
        [HttpPut("UpdateCorrection")]
        public ActionResult UpdateCorrection(CorrectionDto updateCorrection)
        {
            int x = bll.UpdateCorrection(updateCorrection);
            if (x == -1)
                return NotFound();
            return Ok(x);
        }
        [HttpDelete("DeleteCorrection/{DeleteCorrectionId}")]
        public ActionResult DeleteCorrection(int brideJewelryId)
        {
            int x = bll.DeleteCorrection(brideJewelryId);
            if (x == -1)
                return NotFound();
            return Ok();
        }

    }
}
