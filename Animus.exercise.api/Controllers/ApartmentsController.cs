using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Animus.exercise.api.Model;
using System;

namespace Animus.exercise.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentsController : ControllerBase
    {
        private readonly ApartmentsContext _context;

        public ApartmentsController(ApartmentsContext context)
        {
            _context = context;

            // Insert default apartment when collection is empty
            if (_context.Apartments.Count() == 0)
            {
                _context.Apartments.Add(new ApartmentsDTO()
                {
                    id = 1,
                    abailable = "01.05.2019",
                    street = "Wallstreet",
                    plz = 22880,
                    place = "Wedel",
                    country = "Deutschland",
                    email = "wien@wien.com"
                });
                 _context.SaveChanges();
            }
        }
        //TODO: Delete when context works
        List<ApartmentsDTO> apartList = new List<ApartmentsDTO>()
            {
                new ApartmentsDTO()
                {
                    id = 1,
                    abailable = "01.05.2019",
                    street = "Wallstreet",
                    plz = 22880,
                    place = "Wedel",
                    country = "Deutschland",
                    email = "wien@wien.com"
                },
                new ApartmentsDTO()
                {
                    id = 2,
                    abailable = "01.08.2019",
                    street = "Luckstreet",
                    plz = 22880,
                    place = "Wedel",
                    country = "Deutschland",
                    email = "wien@wien.com"
                },
                new ApartmentsDTO()
                {
                    id = 3,
                    abailable = "01.02.2019",
                    street = "Richardstraße",
                    plz = 40472,
                    place = "Düsseldorf",
                    country = "Deutschland",
                    email = "Ratingen@Ratingen.com"
                }
            };

        // GET: api/Apartments
        [HttpGet]
        public IEnumerable<ApartmentsDTO> Get()
        {
            return _context.Apartments.ToList();
        }

        // GET: api/Apartments/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Apartments
        [HttpPost]
        public void Post([FromBody] ApartmentsDTO apartments)
        {
            try
            {
                _context.Apartments.Add(apartments);
                _context.SaveChanges();
            }
            catch (ArgumentException e)
            {
                // ToDo: hapens when id is alredy talken
            }
            
            
        }

        // PUT: api/Apartments/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
