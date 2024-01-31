using Bll.interfaces;
using Bll.interfaces;
using Dto.classes;
using Dto.classes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrideControler : Controller
    {
        IBrideBll bll;
        public BrideControler(IBrideBll _bll)
        {
            bll = _bll;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<BrideDto>> getAll()
        {
            return Ok(bll.GetAll());
        }
        [HttpGet("GetById/{id}")]
        public ActionResult<List<BrideDto>> getById(int id)
        {
            return Ok(bll.GetById(id));
        }

        [HttpPost("AddBride")]
        public ActionResult AddBride(BrideDto newBride)
        {
            int x = bll.AddBride(newBride);
            if (x == -1)
                return NotFound();
            return Ok(x);
        }
        [HttpPut("UpdateBride")]

        public ActionResult PutupdateBride([FromBody] BrideDto updateBride)
        {
            int x = bll.UpdateBride(updateBride);
            if (x == -1)
                return NotFound();
            return Ok(x);
        }

        [HttpDelete("DeleteBride/{id}")]
        public ActionResult<int> deleteBride(int id)
        {
            int x = bll.DeleteBride(id);
            if (x == -1)
                return NotFound();
            return Ok();
        }
    }
}
