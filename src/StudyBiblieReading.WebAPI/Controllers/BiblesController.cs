using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudyBibleReading.Domain.Models;
using StudyBibleReading.Infra.Context;

namespace StudyBiblieReading.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BiblesController : ControllerBase
    {
        private readonly SbrContext _context;

        public BiblesController(SbrContext context)
        {
            _context = context;
        }

        // GET: api/Bibles
        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<Bible>>> GetBibles()
        {
            return await _context.Bibles.ToListAsync();
        }

        // GET: api/Bibles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bible>> GetBible(Guid id)
        {
            var bible = await _context.Bibles.FindAsync(id);

            if (bible == null)
            {
                return NotFound();
            }

            return bible;
        }

        // PUT: api/Bibles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBible(Guid id, Bible bible)
        {
            if (id != bible.Id)
            {
                return BadRequest();
            }

            _context.Entry(bible).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BibleExists(id))
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

        // POST: api/Bibles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bible>> PostBible(Bible bible)
        {
            var publisher = await _context.Publishers.SingleOrDefaultAsync(x => x.Id == bible.Publisher.Id);
            var translation = await _context.Translations.SingleOrDefaultAsync(x => x.Id == bible.Translation.Id);
            bible = new Bible(bible.Title, publisher, translation, bible.Pages, bible.Study);
            _context.Bibles.Add(bible);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBible", new { id = bible.Id }, bible);
        }

        // DELETE: api/Bibles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBible(Guid id)
        {
            var bible = await _context.Bibles.FindAsync(id);
            if (bible == null)
            {
                return NotFound();
            }

            _context.Bibles.Remove(bible);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BibleExists(Guid id)
        {
            return _context.Bibles.Any(e => e.Id == id);
        }
    }
}
