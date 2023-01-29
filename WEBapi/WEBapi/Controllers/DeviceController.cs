using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEBapi.Models;

namespace WEBapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        private readonly UsermContext _dbContext;

        public DeviceController(UsermContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/Devices

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Device>>> GetDevices()
        {
            if (_dbContext.Device == null)
            {
                return NotFound();
            }
            return await _dbContext.Device.ToListAsync();
        }

        // GET: api/Devices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Device>> GetDevice(int deviceId)
        {
            if (_dbContext.Device == null)
            {
                return NotFound();
            }
            var device = await _dbContext.Device.FindAsync(deviceId);

            if (device == null)
            {
                return NotFound();
            }

            return device;
        }

        // POST: api/Devices
        [HttpPost]
        public async Task<ActionResult<Device>> PostDevice(Device device)
        {
            _dbContext.Device.Add(device);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDevice), new { id = device.DeviceId }, device);
        }

        // PUT: api/Devices/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDevice(int deviceId, Device device)
        {
            if (deviceId != device.DeviceId)
            {
                return BadRequest();
            }

            _dbContext.Entry(device).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeviceExists(deviceId))
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

        // DELETE: api/Devices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDevice(int deviceId)
        {
            if (_dbContext.Device == null)
            {
                return NotFound();
            }

            var device = await _dbContext.Device.FindAsync(deviceId);
            if (device == null)
            {
                return NotFound();
            }

            _dbContext.Device.Remove(device);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }


        private bool DeviceExists(long deviceId)
        {
            return (_dbContext.Device?.Any(e => e.DeviceId == deviceId)).GetValueOrDefault();
        }
    }
}
