using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MuseMeiV2.DTOs;
using MuseMeiV2.Services.CategoryServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MuseMeiV2.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<IEnumerable<CategoryDTO>>  Get()
        {
            return await _service.GetAll();
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDTO>> Get(int id)
        {
            var dto = await _service.Get(id);
            if( dto == null)
            {
                return NotFound();
            }
            return dto;
        }

        // POST api/<CategoryController>
        [HttpPost]
        public  async Task<ActionResult<CategoryDTO>> Post(CategoryDTO dto)
        {
            await _service.Add(dto);
            return NoContent();
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CategoryDTO dto)
        {
            if( id != dto.Id)
            {
                return BadRequest();
            }

            try
            {
                await _service.Update(dto);
            }
            catch (Exception)
            {

                throw;
            }
            return NoContent();
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            await _service.Delete(id);
        }
    }
}
