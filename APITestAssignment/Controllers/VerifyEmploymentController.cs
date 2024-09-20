using APITestAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using APITestAssignment.Controllers;
using APITestAssignment.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APITestAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VerifyEmploymentController : ControllerBase
    {
        private readonly EmployeeVerificationContext _context;

        public VerifyEmploymentController(EmployeeVerificationContext context)
        {
            _context = context;
        }

        // POST: api/VerifyEmployment
        [HttpPost]
        public async Task<ActionResult<VerifyEmploymentRequests>> CreateVerifyEmploymentRequest(VerifyEmploymentRequests request)
        {
            _context.VerifyEmploymentRequests.Add(request);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(CreateVerifyEmploymentRequest), new { id = request.EmployeeId }, request);
        }

        // GET: api/VerifyEmployment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VerifyEmploymentRequests>>> GetVerifyEmploymentRequests()
        {
            return await _context.VerifyEmploymentRequests.ToListAsync();
        }

        // GET: api/VerifyEmployment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VerifyEmploymentRequests>> GetVerifyEmploymentRequest(int id)
        {
            var request = await _context.VerifyEmploymentRequests.FindAsync(id);
            return request != null ? request : NotFound();
        }

        // PUT: api/VerifyEmployment/5
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateVerifyEmploymentRequest(int id, VerifyEmploymentRequests request)
        {
            if (id != request.EmployeeId)
            {
                return BadRequest();
            }
            _context.Entry(request).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VerifyEmploymentRequestExists(id))
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

        // DELETE: api/VerifyEmployment/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<VerifyEmploymentRequests>> DeleteVerifyEmploymentRequest(int id)
        {
            var request = await _context.VerifyEmploymentRequests.FindAsync(id);
            if (request == null)
            {
                return NotFound();
            }
            _context.VerifyEmploymentRequests.Remove(request);
            await _context.SaveChangesAsync();
            return request;
        }

        private bool VerifyEmploymentRequestExists(int id)
        {
            return _context.VerifyEmploymentRequests.Any(e => e.EmployeeId == id);
        }
    }

    public class VerifyEmploymentRequests
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string VerificationCode { get; set; }
    }
}


