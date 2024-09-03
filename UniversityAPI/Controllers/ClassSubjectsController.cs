using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversityAPI.Context;
using UniversityAPI.Models;

namespace UniversityAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClassSubjectsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClassSubjectsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassSubject>>> GetClassSubject()
        {
            return await _context.ClassSubject.ToListAsync();
        }

        [HttpGet("{id:int:min(1)}")]
        public async Task<ActionResult<ClassSubject>> GetClassSubject(int id)
        {
            var classSubject = await _context.ClassSubject.FindAsync(id);

            if (classSubject == null)
            {
                return NotFound();
            }

            return classSubject;
        }

        [HttpPut("{id:int:min(1)}")]
        public async Task<IActionResult> PutClassSubject(int id, ClassSubject classSubject)
        {
            if (id != classSubject.ClassSubjectId)
            {
                return BadRequest();
            }

            _context.Entry(classSubject).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassSubjectExists(id))
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
        public async Task<ActionResult<ClassSubject>> PostClassSubject(ClassSubject classSubject)
        {
            _context.ClassSubject.Add(classSubject);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClassSubject", new { id = classSubject.ClassSubjectId }, classSubject);
        }

        [HttpDelete("{id:int:min(1)}")]
        public async Task<IActionResult> DeleteClassSubject(int id)
        {
            var classSubject = await _context.ClassSubject.FindAsync(id);
            if (classSubject == null)
            {
                return NotFound();
            }

            _context.ClassSubject.Remove(classSubject);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClassSubjectExists(int id)
        {
            return _context.ClassSubject.Any(e => e.ClassSubjectId == id);
        }
    }
}
