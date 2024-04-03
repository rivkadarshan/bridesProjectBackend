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
    public class BridejewelryControler : Controller
    {
        IBridejewelryBll bll;
        public BridejewelryControler(IBridejewelryBll _bll)
        {
            bll = _bll;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<BridejewelryDto>> GetAll()
        {
            List<BridejewelryDto> x = bll.GetAll();
            return Ok(bll.GetAll());
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<List<BridejewelryDto>> GetById(int id)
        {
            return Ok(bll.GetById(id));
        }
        [HttpGet("GetJewelryAccordingToBrideId/{id}")]
        public ActionResult<List<BridejewelryDto>> GetJewelryAccordingToBrideId(int id)
        {
            return Ok(bll.GetJewelryAccordingToBrideId(id));
        }
        //צריך לבדות שיש את הכלה ואת התכשיט שמוסיפים
        [HttpPost("AddBrideJewelry")]
        public ActionResult PostaddBrideJewelry(BridejewelryDto newBridejewelry)
        {
            int x = bll.AddBrideJewelry(newBridejewelry);
            if (x == -1)
                return NotFound();
            return Ok(x);
        }
        [HttpPut("UpdateBrideJewelry")]
        public ActionResult UpdateBrideJewelry(int jewelryId, int brideId)
        {
            int x = bll.UpdateBrideJewelry(jewelryId,brideId);
            if (x == -1)
                return NotFound();
            return Ok(x);
        }
        [HttpDelete("DeleteBrideJewelry/{brideJewelryId}")]
        public ActionResult DeleteBrideJewelry(int brideJewelryId)
        {
            int x = bll.DeleteBrideJewelry(brideJewelryId);
            if (x == -1)
                return NotFound();
            return Ok();
        }
        [HttpPut("UpdateListBrideJewelry")]
        public ActionResult UpdateListBrideJewelry(List<BridejewelryDto> updatedBrideJewelryList)
        {
            try
            {
                bll.UpdateListBrideJewelry(updatedBrideJewelryList);
                return Ok("Bride jewelry list updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

    }
}
