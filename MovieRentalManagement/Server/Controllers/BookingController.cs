using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieRentalManagement.Server.IRepository;
using MovieRentalManagement.Shared.Domain;

namespace MovieRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public BookingController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBookings()
        {
            return Ok(await _unit.BookingRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var booking = await _unit.BookingRepository.Get(x => x.Id == id);

            if (booking == null)
            {
                return NotFound();
            }
            return Ok(booking);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGenre(int id, Booking booking)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            _unit.BookingRepository.Update(booking);

            try
            {
                await _unit.Complete(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await BookingExists(id))
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
        public async Task<IActionResult> AddGenre(Booking booking)
        {
            await _unit.BookingRepository.Insert(booking);
            await _unit.Complete(HttpContext);

            return CreatedAtAction("GetById", new { id = booking.Id }, booking);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteGenre(int id)
        {
            await _unit.BookingRepository.Delete(id);
            await _unit.Complete(HttpContext);
            return NoContent();
        }

        private async Task<bool> BookingExists(int id)
        {
            var entity = await _unit.BookingRepository.Get(x => x.Id == id);

            return entity == null;
        }

    }
}
