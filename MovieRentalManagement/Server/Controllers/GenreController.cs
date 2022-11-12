using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieRentalManagement.Server.IRepository;
using MovieRentalManagement.Shared.Domain;

namespace MovieRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public GenreController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGenres()
        {
            return Ok(await _unit.GenreRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var genre = await _unit.GenreRepository.Get(x => x.Id == id);

            if(genre == null)
            {
                return NotFound();
            }
            return Ok(genre);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGenre(int id, Genre genre)
        {
            if(id == 0)
            {
                return BadRequest();
            }

            _unit.GenreRepository.Update(genre);

            try
            {
                await _unit.Complete(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (! await GenreExists(id))
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
        public async Task<IActionResult> AddGenre(Genre genre)
        {
            await _unit.GenreRepository.Insert(genre);
            await _unit.Complete(HttpContext);

            return CreatedAtAction("GetById", new { id = genre.Id }, genre);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteGenre(int id)
        {
            await _unit.GenreRepository.Delete(id);
            await _unit.Complete(HttpContext);
            return NoContent();
        }

        private async Task<bool> GenreExists(int id)
        {
            var entity = await _unit.GenreRepository.Get(x => x.Id == id);

            return entity == null;
        }

    }
}
