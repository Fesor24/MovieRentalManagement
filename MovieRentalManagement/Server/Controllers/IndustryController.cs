using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieRentalManagement.Server.IRepository;
using MovieRentalManagement.Shared.Domain;

namespace MovieRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndustryController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public IndustryController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllIndustries()
        {
            return Ok(await _unit.IndustryRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var industry = await _unit.IndustryRepository.Get(x => x.Id == id);

            if (industry == null)
            {
                return NotFound();
            }
            return Ok(industry);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateIndustry(int id, Industry industry)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            _unit.IndustryRepository.Update(industry);

            try
            {
                await _unit.Complete(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await IndustryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> AddIndustry(Industry industry)
        {
            await _unit.IndustryRepository.Insert(industry);
            await _unit.Complete(HttpContext);

            return CreatedAtAction("GetById", new { id = industry.Id }, industry);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteGenre(int id)
        {
            await _unit.IndustryRepository.Delete(id);
            await _unit.Complete(HttpContext);
            return NoContent();
        }

        private async Task<bool> IndustryExists(int id)
        {
            var entity = await _unit.IndustryRepository.Get(x => x.Id == id);

            return entity == null;
        }

    }
}
