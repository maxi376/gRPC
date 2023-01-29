using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEBapi.Models;

namespace WEBapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsermController : ControllerBase
    {
        private readonly UsermContext _dbContext;

        public UsermController(UsermContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/Userms

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Userm>>> GetUserms()
        {
            //try
            //{
                if (_dbContext.Userm == null)
                {
                    return NotFound();
                }
                //return await _dbContext.Userms.ToListAsync();

                //List<Userm> listUserms = _dbContext.Userms.ToList();
                //return Ok(listUserms);
                return await _dbContext.Userm.ToListAsync();

            //}catch(Exception ex) { 
            //    return BadRequest(ex.Message);
            //}
        }

        // GET: api/Userms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Userm>> GetUserm(int usermId)
        {
            if (_dbContext.Userm == null)
            {
                return NotFound();
            }
            var userm = await _dbContext.Userm.FindAsync(usermId);

            if (userm == null)
            {
                return NotFound();
            }

            return userm;
        }

        // POST: api/Userms
        [HttpPost]
        public async Task<ActionResult<Userm>> PostUserm(Userm userm)
        {
            _dbContext.Userm.Add(userm);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUserm), new { id = userm.UsermId }, userm);
        }

        // PUT: api/Userms/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserm(int usermId, Userm userm)
        {
            if (usermId != userm.UsermId)
            {
                return BadRequest();
            }

            _dbContext.Entry(userm).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsermExists(usermId))
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

        // DELETE: api/Userms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserm(int usermId)
        {
            if (_dbContext.Userm == null)
            {
                return NotFound();
            }

            var userm = await _dbContext.Userm.FindAsync(usermId);
            if (userm == null)
            {
                return NotFound();
            }

            _dbContext.Userm.Remove(userm);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }


        private bool UsermExists(long usermId)
        {
            return (_dbContext.Userm?.Any(e => e.UsermId == usermId)).GetValueOrDefault();
        }
    }
}
