using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using iob_smart_webapi.Models;

namespace iob_smart_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratacoesController : ControllerBase
    {
        private readonly ContratacaoContext _context;

        public ContratacoesController(ContratacaoContext context)
        {
            _context = context;
        }

        // GET: api/Contratacoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contratacao>>> GetContratacao()
        {
          if (_context.Contratacao == null)
          {
              return NotFound();
          }
            return await _context.Contratacao.ToListAsync();
        }

        // GET: api/Contratacoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contratacao>> GetContratacao(long id)
        {
          if (_context.Contratacao == null)
          {
              return NotFound();
          }
            var contratacao = await _context.Contratacao.FindAsync(id);

            if (contratacao == null)
            {
                return NotFound();
            }

            return contratacao;
        }

        // PUT: api/Contratacoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContratacao(long id, Contratacao contratacao)
        {
            if (id != contratacao.ContratacaoId)
            {
                return BadRequest();
            }

            _context.Entry(contratacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContratacaoExists(id))
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

        // POST: api/Contratacoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Contratacao>> PostContratacao(Contratacao contratacao)
        {
          if (_context.Contratacao == null)
          {
              return Problem("Entity set 'ContratacaoContext.Contratacao'  is null.");
          }
            _context.Contratacao.Add(contratacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetContratacao), new { id = contratacao.ContratacaoId }, contratacao);
        }

        // DELETE: api/Contratacoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContratacao(long id)
        {
            if (_context.Contratacao == null)
            {
                return NotFound();
            }
            var contratacao = await _context.Contratacao.FindAsync(id);
            if (contratacao == null)
            {
                return NotFound();
            }

            _context.Contratacao.Remove(contratacao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContratacaoExists(long id)
        {
            return (_context.Contratacao?.Any(e => e.ContratacaoId == id)).GetValueOrDefault();
        }
    }
}
