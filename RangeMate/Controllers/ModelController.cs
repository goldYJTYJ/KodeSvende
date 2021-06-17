using System;
using ModelLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : Controller
    {
        private readonly RangeMateContext _RangeMatecontext;
        public ModelController(RangeMateContext RangeMatecontext)
        {
            _RangeMatecontext = RangeMatecontext;
        }

        // Get list of all models, given manufacturer ID
        [HttpGet("GetModelListAdmin/{ManufacturerID}", Name = "GetModelListAdmin")]
        public IActionResult GetModelListAdmin([FromRoute] int ManufacturerID)
        {
            try
            {
                var AllModels = _RangeMatecontext.Models.Where(x => x.ManufacturerId == ManufacturerID);
                return Ok(AllModels.OrderBy(x => x.ModelName));
            }
            catch (Exception)
            {
                // if database connection fails return error
                return Ok("Could Not Connect To Database.");
            }
        }

        // Create model from model object
        [HttpPost("CreateModel", Name = "CreateModel.")]
        public IActionResult CreateModel([FromBody] Model model)
        {
            try
            {
                // Check if the recived model is valid
                if (!ModelState.IsValid)
                {
                    return Ok("Model State Invalid.");
                }

                if (!_RangeMatecontext.Manufacturer.Any(ManufacturerID => ManufacturerID.Id == model.ManufacturerId))
                {
                    return Ok("Manufacturer ID does not exists.");
                }

                //Check if a Model with that name already exists
                Model checkModel = _RangeMatecontext.Models.FirstOrDefault(x => x.ModelName.ToLower() == model.ModelName.ToLower() && x.Year == model.Year && x.Id == model.ManufacturerId);
                if (checkModel != null)
                {
                    return Ok("A Model with this name already exists.");
                }
                else
                {
                    _RangeMatecontext.Add(model);
                    _RangeMatecontext.SaveChanges();

                    return Ok("Model has been created.");
                }
            }
            catch (Exception)
            {
                // if database connection fails return error
                return Ok("Could Not Connect To Database.");
            }

        }


        [HttpPost("UpdateModel", Name = "UpdateModel")]
        public IActionResult UpdateModel([FromBody] Model model)
        {
            try
            {
                // Check if the recived model is valid
                if (!ModelState.IsValid)
                {
                    return Ok("Model State Invalid.");
                }

                //finde current manufacturer trying to edit
                Model ModelFromDb = _RangeMatecontext.Models.FirstOrDefault(x => x.Id == model.Id);
                if (ModelFromDb == null)
                {
                    return Ok("Model not found.");
                }

                //Check if a Model with that name already exists
                var AllModelsFromDb = _RangeMatecontext.Models.ToList();
                AllModelsFromDb.RemoveAll(x => x.Id == model.Id);
                if (AllModelsFromDb.Any(us => us.ModelName.ToLower() == model.ModelName.ToLower() && us.Year == model.Year))
                {
                    return Ok("A Model with that name already exists.");
                }
                else
                {
                    ModelFromDb.ModelName = model.ModelName;
                    ModelFromDb.Year = model.Year;
                    ModelFromDb.Is_Active = model.Is_Active;
                    _RangeMatecontext.SaveChanges();

                    return Ok("Model has been updated.");
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
