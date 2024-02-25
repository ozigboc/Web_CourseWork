using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_CourseWork.Models;

namespace Web_CourseWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employee_SkillsController : ControllerBase
    {
        private readonly OrganisationContext _context;

        public Employee_SkillsController(OrganisationContext context)
        {
            _context = context;
        }

        // GET: api/Employee_Skills
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee_Skills>>> GetEmployee_Skills()
        {
            return await _context.Employee_Skills.ToListAsync();
        }

        // GET: api/Employee_Skills/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee_Skills>> GetEmployee_Skills(int? id)
        {
            var employee_Skills = await _context.Employee_Skills.FindAsync(id);

            if (employee_Skills == null)
            {
                return NotFound();
            }

            return employee_Skills;
        }

        // PUT: api/Employee_Skills/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee_Skills(int? id, Employee_Skills employee_Skills)
        {
            if (id != employee_Skills.Id)
            {
                return BadRequest();
            }

            _context.Entry(employee_Skills).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Employee_SkillsExists(id))
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

        // POST: api/Employee_Skills
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employee_Skills>> PostEmployee_Skills(Employee_Skills employee_Skills)
        {
            _context.Employee_Skills.Add(employee_Skills);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployee_Skills", new { id = employee_Skills.Id }, employee_Skills);
        }

        // DELETE: api/Employee_Skills/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee_Skills(int? id)
        {
            var employee_Skills = await _context.Employee_Skills.FindAsync(id);
            if (employee_Skills == null)
            {
                return NotFound();
            }

            _context.Employee_Skills.Remove(employee_Skills);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Employee_SkillsExists(int? id)
        {
            return _context.Employee_Skills.Any(e => e.Id == id);
        }
    }
}
