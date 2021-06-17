using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelLibrary;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EngineController : Controller
    {
        private readonly RangeMateContext _RangeMatecontext;
        public EngineController(RangeMateContext RangeMatecontext)
        {
            _RangeMatecontext = RangeMatecontext;
        }

        // Get List of all Engines given model ID
        [HttpGet("GetEngineListAdmin/{ModelID}", Name = "GetEngineListAdmin")]
        public IActionResult GetEngineListAdmin([FromRoute] int ModelID)
        {
            try
            {
                var AllEngines = _RangeMatecontext.Engine.Where(x => x.ModelId == ModelID);
                if (AllEngines.Any() == false)
                {
                    return Ok(AllEngines.OrderBy(x => x.Type));
                }

                return Ok(AllEngines);
            }
            catch (Exception)
            {
                // if database connection fails return empty for error handling purposes
                List<Engine> AllEngines = new List<Engine>();
                return Ok(AllEngines);
            }
        }

        [HttpPost("CreateEngine", Name = "CreateEngine")]
        public IActionResult CreateEngine([FromBody] Engine engine)
        {
            try
            {
                // Check if the recived model is valid
                if (!ModelState.IsValid)
                {
                    return Ok("Model State Invalid.");
                }

                if (!_RangeMatecontext.Models.Any(ModelID => ModelID.Id == engine.ModelId))
                {
                    return Ok("Model ID does not exists.");
                }

                Engine checkEngine = _RangeMatecontext.Engine.FirstOrDefault(x => x.Type.ToLower() == engine.Type.ToLower() && x.ModelId == engine.ModelId);
                if (checkEngine != null)
                {
                    return Ok("A Engine with this type already exists.");
                }
                else
                {
                    if(engine.Is_Electric == true)
                    {
                        engine.Watt_Hours_Per_KM = Math.Round(((Convert.ToDouble(engine.Size) / Convert.ToDouble(engine.WLTP)) * 100), 2).ToString();
                    }
                    _RangeMatecontext.Add(engine);
                    _RangeMatecontext.SaveChanges();

                    return Ok("Engine has been created.");
                }
            }
            catch (Exception)
            {
                // if database connection fails return error
                return Ok("Could Not Connect To Database.");
            }
        }


        [HttpPost("UpdateEngine", Name = "UpdateEngine")]
        public IActionResult UpdateEngine([FromBody] Engine engine)
        {
            try
            {
                // Check if the recived model is valid
                if (!ModelState.IsValid)
                {
                    return Ok("Model State Invalid.");
                }

                //finde current Engine trying to edit
                Engine EngineFromDb = _RangeMatecontext.Engine.FirstOrDefault(x => x.Id == engine.Id);
                if (EngineFromDb == null)
                {
                    return Ok("Engine not found.");
                }

                // SKal ændres til at den kun kigger i en models motor. 
                //Check if a engine with that type already exists
                var AllEnginesFromDb = _RangeMatecontext.Engine.Where(en => en.ModelId == engine.ModelId).ToList();
                AllEnginesFromDb.RemoveAll(x => x.Id == engine.Id);
                if (AllEnginesFromDb.Any(us => us.Type.ToLower() == engine.Type.ToLower()))
                {
                    return Ok("A Engine with that type already exists.");
                }
                else
                {
                    EngineFromDb.Type = engine.Type;
                    EngineFromDb.Size = engine.Size;
                    EngineFromDb.Fuel = engine.Fuel;
                    EngineFromDb.WLTP = engine.WLTP;
                    EngineFromDb.NEDC = engine.NEDC;
                    if (engine.Is_Electric == true)
                    {
                        EngineFromDb.Watt_Hours_Per_KM = Math.Round(((Convert.ToDouble(EngineFromDb.Size) / Convert.ToDouble(EngineFromDb.WLTP)) * 100), 2).ToString();
                    }
                    EngineFromDb.Is_Active = engine.Is_Active;
                    EngineFromDb.Is_Electric = engine.Is_Electric;
                    _RangeMatecontext.SaveChanges();

                    return Ok("Engine has been updated.");
                }
            }
            catch (Exception)
            {
                // if database connection fails return error
                return Ok("Could Not Connect To Database.");
            }
        }
    }
}
