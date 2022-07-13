using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BloodBank.Data;
using BloodBank.Models;

namespace BloodBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupbloodsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GroupbloodsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Groupbloods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Groupblood>>> GetGroupbloods()
        {
            return await _context.Groupbloods.ToListAsync();
        }

        // GET: api/Groupbloods/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Groupblood>> GetGroupblood(int id)
        {
            var groupblood = await _context.Groupbloods.FindAsync(id);

            if (groupblood == null)
            {
                return NotFound();
            }

            return groupblood;
        }

        // PUT: api/Groupbloods/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGroupblood(int id, Groupblood groupblood)
        {
            if (id != groupblood.GroupbloodId)
            {
                return BadRequest();
            }

            _context.Entry(groupblood).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupbloodExists(id))
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

        // POST: api/Groupbloods
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Groupblood>> PostGroupblood(Groupblood groupblood)
        {
            _context.Groupbloods.Add(groupblood);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGroupblood", new { id = groupblood.GroupbloodId }, groupblood);
        }

        // DELETE: api/Groupbloods/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGroupblood(int id)
        {
            var groupblood = await _context.Groupbloods.FindAsync(id);
            if (groupblood == null)
            {
                return NotFound();
            }

            _context.Groupbloods.Remove(groupblood);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GroupbloodExists(int id)
        {
            return _context.Groupbloods.Any(e => e.GroupbloodId == id);
        }
    }
}
