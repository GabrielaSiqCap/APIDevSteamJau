using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIDevSteamJau.Data;
using APIDevSteamJau.Models;

namespace APIDevSteamJau.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuponsCarrinhosController : ControllerBase
    {
        private readonly APIContext _context;

        public CuponsCarrinhosController(APIContext context)
        {
            _context = context;
        }

        // GET: api/CuponsCarrinhos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CupomCarrinho>>> GetCupomCarrinho()
        {
            return await _context.CupomCarrinho.ToListAsync();
        }

        // GET: api/CuponsCarrinhos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CupomCarrinho>> GetCupomCarrinho(Guid id)
        {
            var cupomCarrinho = await _context.CupomCarrinho.FindAsync(id);

            if (cupomCarrinho == null)
            {
                return NotFound();
            }

            return cupomCarrinho;
        }

        // PUT: api/CuponsCarrinhos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCupomCarrinho(Guid id, CupomCarrinho cupomCarrinho)
        {
            if (id != cupomCarrinho.CupomCarrinhoId)
            {
                return BadRequest();
            }

            _context.Entry(cupomCarrinho).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CupomCarrinhoExists(id))
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

        // POST: api/CuponsCarrinhos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CupomCarrinho>> PostCupomCarrinho(CupomCarrinho cupomCarrinho)
        {
            _context.CupomCarrinho.Add(cupomCarrinho);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCupomCarrinho", new { id = cupomCarrinho.CupomCarrinhoId }, cupomCarrinho);
        }

        // DELETE: api/CuponsCarrinhos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCupomCarrinho(Guid id)
        {
            var cupomCarrinho = await _context.CupomCarrinho.FindAsync(id);
            if (cupomCarrinho == null)
            {
                return NotFound();
            }

            _context.CupomCarrinho.Remove(cupomCarrinho);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CupomCarrinhoExists(Guid id)
        {
            return _context.CupomCarrinho.Any(e => e.CupomCarrinhoId == id);
        }
    }
}
