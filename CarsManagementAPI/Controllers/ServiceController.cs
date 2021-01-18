using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsManagementAPI.Context;
using CarsManagementAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarsManagementAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly CarsManagementAPIContext _context;

        public ServiceController(CarsManagementAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Service>>> GetService()
        {
            return await _context.Service.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Service>> GetService(int id)
        {
            var service = await _context.Service.FindAsync(id);

            if (service == null)
            {
                return NotFound();
            }

            return service;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Service>> PutUser(int id, Service service)
        {
            if (id != service.Id)
            {
                return BadRequest();
            }

            _context.Entry(service).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) //można zaimplementować loggera, jeżeli wywali nam jakiś inny błąd to wszstko zalogujemy do txt
            {
                if (!ServiceExists(id))
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
        public async Task<ActionResult<Service>> PostService(Service service)
        {
            _context.Service.Add(service);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetService", new {id = service.Id}, service);
        }

        private bool ServiceExists(int id)
        {
            return _context.Service.Any(e => e.Id == id);
        }
    }
}