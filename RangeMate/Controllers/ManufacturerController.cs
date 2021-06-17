using Microsoft.AspNetCore.Mvc;
using ModelLibrary;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly RangeMateContext _RangeMatecontext;
        public ManufacturerController(RangeMateContext RangeMatecontext)
        {
            _RangeMatecontext = RangeMatecontext;
        }

        // Get list of all manufacturers
        [HttpGet("GetManufacturerListAdmin", Name = "GetManufacturerListAdmin")]
        public IActionResult GetManufacturerListAdmin()
        {
            try
            {
                var AllManufacturers = _RangeMatecontext.Manufacturer.ToList();
                return Ok(AllManufacturers.OrderBy(x => x.Name));
            }
            catch (Exception)
            {
                // if database connection fails return error
                return Ok("Could Not Connect To Database.");
            }
        }

        [HttpPost("CreateManfacturer", Name = "CreateManfacturer")]
        public IActionResult CreateManfacturer([FromBody] Manufacturer Manufacturer)
        {
            try
            {
                // Check if the recived model is valid
                if (!ModelState.IsValid)
                {
                    return Ok("Model State Invalid.");
                }

                //Check if a manufacturer with that name already exists
                Manufacturer checkManufacturer = _RangeMatecontext.Manufacturer.FirstOrDefault(x => x.Name.ToLower() == Manufacturer.Name.ToLower());
                if (checkManufacturer != null)
                {
                    return Ok("A Manufacturer with this name already exists.");
                }
                else
                {
                    _RangeMatecontext.Add(Manufacturer);
                    _RangeMatecontext.SaveChanges();

                    return Ok("Manufacturer has been created.");
                }
            }
            catch (Exception)
            {
                // if database connection fails return error
                return Ok("Could Not Connect To Database.");
            }
        }

        [HttpPost("UpdateManfacturer", Name = "UpdateManfacturer")]
        public IActionResult UpdateManfacturer([FromBody] Manufacturer Manufacturer)
        {
            try
            {
                // Check if the recived model is valid
                if (!ModelState.IsValid)
                {
                    return Ok("Model State Invalid.");
                }

                //finde current manufacturer trying to edit
                Manufacturer manufacturerFromDb = _RangeMatecontext.Manufacturer.FirstOrDefault(x => x.Id == Manufacturer.Id);
                if (manufacturerFromDb == null)
                {
                    return Ok("Manufacturer not found.");
                }

                //Check if a manufacturer with that name already exists
                var AllManufacturerFromDb = _RangeMatecontext.Manufacturer.ToList();
                AllManufacturerFromDb.RemoveAll(x => x.Id == Manufacturer.Id);
                if (AllManufacturerFromDb.Any(us => us.Name.ToLower() == Manufacturer.Name.ToLower()))
                {
                    return Ok("A Manufacturer with this name already exists");
                }

                manufacturerFromDb.Name = Manufacturer.Name;
                manufacturerFromDb.Is_Active = Manufacturer.Is_Active;
                _RangeMatecontext.SaveChanges();

                return Ok("Manufacturer has been updated.");
            }
            catch (Exception)
            {
                // if database connection fails return error
                return Ok("Could Not Connect To Database");
            }
        }
    }
}
