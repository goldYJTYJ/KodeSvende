using Microsoft.AspNetCore.Mvc;
using ModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : Controller
    {
        private readonly RangeMateContext _RangeMatecontext;
        public SearchController(RangeMateContext rangeMateContext)
        {
            _RangeMatecontext = rangeMateContext;
        }

        // Get list of all manufacturers
        [HttpGet("GetManufacturerList", Name = "GetManufacturerList")]
        public IActionResult GetManufacturerList()
        {
            try
            {
                var AllManufacturers = _RangeMatecontext.Manufacturer
                    .Where(x => x.Is_Active).OrderBy(x => x.Name).ToList();
                return Ok(AllManufacturers);
            }
            catch (Exception)
            {
                // if database connection fails return empty for error handling purposes
                return Ok("Could Not Connect To Database.");
            }
        }

        // Get list of all models, given manufacturer ID
        [HttpGet("{ManufacturerID}", Name = "GetModelList")]
        public IActionResult GetModelList([FromQuery] int ManufacturerID)
        {
            try
            {
                var AllModels = _RangeMatecontext.Models.Where(x => x.ManufacturerId == ManufacturerID && x.Is_Active).OrderBy(x => x.ModelName);
                return Ok(AllModels);
            }
            catch (Exception)
            {
                // if database connection fails return empty for error handling purposes
                return Ok("Could Not Connect To Database.");
            }
        }

        // Get List of all Engines given model ID
        [HttpGet("GetEngineList/{ModelID}", Name = "GetEngineList")]
        public IActionResult GetEngineList([FromRoute] int ModelID)
        {
            try
            {
                var AllEngines = _RangeMatecontext.Engine.Where(x => x.ModelId == ModelID && x.Is_Active).OrderBy(x => x.Size);
                return Ok(AllEngines);
            }
            catch (Exception)
            {
                // if database connection fails return empty for error handling purposes
                return Ok("Could Not Connect To Database.");
            }
        }

        // Get manufacturer from id
        [HttpGet("Get/Manufacturer/{ManufacturerID}", Name = "GetManufacturer")]
        public IActionResult GetManufacturer([FromRoute] int ManufacturerID)
        {
            try
            {
                var AllModels = _RangeMatecontext.Manufacturer.Where(x => x.Id == ManufacturerID);
                return Ok(AllModels);
            }
            catch (Exception)
            {
                // if database connection fails return error
                return Ok("Could Not Connect To Database.");
            }
        }
    }
}
