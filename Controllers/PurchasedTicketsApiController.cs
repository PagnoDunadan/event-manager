using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EventManager.Models;

namespace EventManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasedTicketsApiController : ControllerBase
    {
        private readonly EventManagerContext _context;

        public PurchasedTicketsApiController(EventManagerContext context)
        {
            _context = context;
        }

        // GET: api/PurchasedTicketsApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchasedTicket>>> GetPurchasedTickets()
        {
            return await _context.PurchasedTickets.ToListAsync();
        }

        // GET: api/PurchasedTicketsApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchasedTicket>> GetPurchasedTicket(int id)
        {
            var purchasedTicket = await _context.PurchasedTickets.FindAsync(id);

            if (purchasedTicket == null)
            {
                return NotFound();
            }

            return purchasedTicket;
        }

        // PUT: api/PurchasedTicketsApi/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchasedTicket(int id, PurchasedTicket purchasedTicket)
        {
            if (id != purchasedTicket.ID)
            {
                return BadRequest();
            }

            _context.Entry(purchasedTicket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchasedTicketExists(id))
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

        // POST: api/PurchasedTicketsApi
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PurchasedTicket>> PostPurchasedTicket(PurchasedTicket purchasedTicket)
        {
            _context.PurchasedTickets.Add(purchasedTicket);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurchasedTicket", new { id = purchasedTicket.ID }, purchasedTicket);
        }

        // DELETE: api/PurchasedTicketsApi/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PurchasedTicket>> DeletePurchasedTicket(int id)
        {
            var purchasedTicket = await _context.PurchasedTickets.FindAsync(id);
            if (purchasedTicket == null)
            {
                return NotFound();
            }

            _context.PurchasedTickets.Remove(purchasedTicket);
            await _context.SaveChangesAsync();

            return purchasedTicket;
        }

        private bool PurchasedTicketExists(int id)
        {
            return _context.PurchasedTickets.Any(e => e.ID == id);
        }
    }
}
