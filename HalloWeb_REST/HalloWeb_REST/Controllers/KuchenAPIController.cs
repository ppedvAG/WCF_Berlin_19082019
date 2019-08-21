using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HalloWeb_REST.Models;

namespace HalloWeb_REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KuchenAPIController : ControllerBase
    {
        private readonly KuchenContext _context;

        public KuchenAPIController(KuchenContext context)
        {
            _context = context;
        }

        // GET: api/KuchenAPI
        [HttpGet]
        public IEnumerable<Kuchen> GetKuchen()
        {
            return _context.Kuchen;
        }

        // GET: api/KuchenAPI/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetKuchen([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var kuchen = await _context.Kuchen.FindAsync(id);

            if (kuchen == null)
            {
                return NotFound();
            }

            return Ok(kuchen);
        }

        // PUT: api/KuchenAPI/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKuchen([FromRoute] int id, [FromBody] Kuchen kuchen)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kuchen.Id)
            {
                return BadRequest();
            }

            _context.Entry(kuchen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KuchenExists(id))
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

        // POST: api/KuchenAPI
        [HttpPost]
        public async Task<IActionResult> PostKuchen([FromBody] Kuchen kuchen)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Kuchen.Add(kuchen);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKuchen", new { id = kuchen.Id }, kuchen);
        }

        // DELETE: api/KuchenAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKuchen([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var kuchen = await _context.Kuchen.FindAsync(id);
            if (kuchen == null)
            {
                return NotFound();
            }

            _context.Kuchen.Remove(kuchen);
            await _context.SaveChangesAsync();

            return Ok(kuchen);
        }

        private bool KuchenExists(int id)
        {
            return _context.Kuchen.Any(e => e.Id == id);
        }
    }
}