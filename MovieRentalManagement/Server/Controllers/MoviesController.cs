using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieRentalManagement.Server.IRepository;
using MovieRentalManagement.Shared.Domain;

namespace MovieRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public MoviesController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMovies()
        {
            var includes = new List<string> { "Genre", "Industry" };
            return Ok(await _unit.MovieRepository.GetAll(includes: includes));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var includes = new List<string> { "Genre", "Industry", "Bookings"};
            var movie = await _unit.MovieRepository.Get(x => x.Id == id);

            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovie(int id, Movie movie)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            _unit.MovieRepository.Update(movie);

            try
            {
                await _unit.Complete(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await MovieExists(id))
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
        public async Task<IActionResult> AddMovie(Movie movie)
        {
            await _unit.MovieRepository.Insert(movie);
            await _unit.Complete(HttpContext);

            return CreatedAtAction("GetById", new { id = movie.Id }, movie);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGenre(int id)
        {
            await _unit.MovieRepository.Delete(id);
            await _unit.Complete(HttpContext);
            return NoContent();
        }

        private async Task<bool> MovieExists(int id)
        {
            var entity = await _unit.GenreRepository.Get(x => x.Id == id);

            return entity == null;
        }

    }
}
