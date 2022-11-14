using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieRentalManagement.Server.IRepository;
using MovieRentalManagement.Shared.Domain;

namespace MovieRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public CustomerController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            return Ok(await _unit.CustomerRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var customer = await _unit.CustomerRepository.Get(x => x.Id == id);

            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGenre(int id, Customer customer)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            _unit.CustomerRepository.Update(customer);

            try
            {
                await _unit.Complete(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CustomerExists(id))
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
        public async Task<IActionResult> AddCustomer(Customer customer)
        {
            await _unit.CustomerRepository.Insert(customer);
            await _unit.Complete(HttpContext);

            return CreatedAtAction("GetById", new { id = customer.Id }, customer);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGenre(int id)
        {
            await _unit.CustomerRepository.Delete(id);
            await _unit.Complete(HttpContext);
            return NoContent();
        }

        private async Task<bool> CustomerExists(int id)
        {
            var entity = await _unit.CustomerRepository.Get(x => x.Id == id);

            return entity == null;
        }

    }
}
