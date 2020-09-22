
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MuseMeiV2.DTOs;
using MuseMeiV2.Models;
using MuseMeiV2.Services.ClothServices;

namespace MuseMeiV2.Controllers
{
    [Route("api/clothes")]
    [ApiController]
    public class ClothController : ControllerBase
    {
        private readonly IClothService _service;

        public ClothController(IClothService service)
        {
            _service = service;
        }



        // GET: api/Cloth
        [HttpGet("all-clothes")]
        public async Task<IEnumerable<ClothDTO>> GetClothDTO()
        {
            return await _service.GetAll();
        }


        [HttpGet]
        public async Task<IEnumerable<ClothDTO>> GetClothes([FromQuery]int categoryId)
        {
            return await _service.GetClothesByCategoryId(categoryId);
        }


        // GET: api/Cloth/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClothDTO>> GetClothDTO(int id)
        {
            ClothDTO dto = await _service.Get(id);

            if (dto == null)
            {
                return NotFound();
            }

            return dto;
        }

        // PUT: api/Cloth/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutClothDTO(int id, ClothDTO clothDTO)
        //{
        //    //if (id != clothDTO.Id)
        //    //{
        //    //    return BadRequest();
        //    //}

        //    //_context.Entry(clothDTO).State = EntityState.Modified;

        //    //try
        //    //{
        //    //    await _context.SaveChangesAsync();
        //    //}
        //    //catch (DbUpdateConcurrencyException)
        //    //{
        //    //    if (!ClothDTOExists(id))
        //    //    {
        //    //        return NotFound();
        //    //    }
        //    //    else
        //    //    {
        //    //        throw;
        //    //    }
        //    //}

        //    return NoContent();
        //}

        // POST: api/Cloth
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<ClothDTO>> PostClothDTO(ClothDTO clothDTO)
        //{
        //    //_context.ClothDTO.Add(clothDTO);
        //    //await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetClothDTO", new { id = clothDTO.Id }, clothDTO);
        //}

        // DELETE: api/Cloth/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<ClothDTO>> DeleteClothDTO(int id)
        //{
        //    var clothDTO = await _context.ClothDTO.FindAsync(id);
        //    if (clothDTO == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.ClothDTO.Remove(clothDTO);
        //    await _context.SaveChangesAsync();

        //    return clothDTO;
        //}

        //private bool ClothDTOExists(int id)
        //{
        //    return _context.ClothDTO.Any(e => e.Id == id);
        //}
    }
}
