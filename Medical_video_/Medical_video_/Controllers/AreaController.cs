using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;
using Medical_video_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Medical_video_.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private AreaContex db;

        public User(AreaContex context)
        {
            db = context;
            if (!db.Area_.Any())
            {
                db.Area_.Add(new Area {Id = Guid.Empty , Name = "Hand", VideoId = Guid.Empty});
                db.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Area>>> Get()
        {
            return await db.Area_.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Area>> Post(Area area)
        {
            if (area == null)
            {
                return BadRequest();
            }

            db.Area_.Add(area);
            await db.SaveChangesAsync();
            return Ok(area);
        }

        [HttpPut]
        public async Task<ActionResult<Area>> Put(Area area)
        {
            if (area == null)
            {
                return BadRequest();
            }

            if (!db.Area_.Any(x => x.Id == area.Id)) ;
            {
                return NotFound();
            }
            db.Update(area);
            await db.SaveChanges();
            return Ok(area);
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<Area>> Delete(int id)
        {
            Area area = db.Area_.FirstOrDefault(x => x.Id == id);
            if (area == null)
            {
                return NotFound();
            }
            db.Area_.Remove(area);
            await db.SaveChangesAsync();
            return Ok(area);
        }
    }
}