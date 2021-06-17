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
    public class CommentController : Controller
    {
        private readonly RangeMateContext _RangeMatecontext;
        public CommentController(RangeMateContext rangeMateContext)
        {
            _RangeMatecontext = rangeMateContext;
        }

        // Get comments for model
        [HttpGet("Get/Comments/{ModelID}", Name = "GetComments")]
        public IActionResult GetComments([FromRoute] int ModelID)
        {
            try
            {
                var GetComments = _RangeMatecontext.Comment
                    .Where(x => x.ModelID == ModelID)
                    .ToList();
                return Ok(GetComments);
            }
            catch (Exception)
            {
                return Ok("Could Not Connect To Database.");
            }
        }

        // Create Comment
        [HttpPost("Create/Comment", Name = "CreateComment")]
        public IActionResult CreateComment([FromBody] Comment comment)
        {
            // Check if the recived model is valid
            if (!ModelState.IsValid)
            {
                return Ok("Model State Invalid.");
            }

            try
            {
                _RangeMatecontext.Comment.Add(comment);
                _RangeMatecontext.SaveChanges();

                return Ok("Comment Saved.");
            }
            catch (Exception)
            {
                return Ok("Could Not Connect To Database.");
            }

        }

        // Deactivate/activate Comment
        [HttpPost("DeactivateActivateComment/Comment", Name = "DeactivateActivateComment")]
        public IActionResult DeactivateComment([FromBody] Comment comment)
        {
            // Check if the recived model is valid
            if (!ModelState.IsValid)
            {
                return Ok("Model State Invalid.");
            }

            try
            {
                var commentDeactivateActivate = _RangeMatecontext.Comment.First(x => x.Id == comment.Id);
                if (comment.Is_Active == false)
                {
                    commentDeactivateActivate.Is_Active = false;
                    _RangeMatecontext.SaveChanges();
                    return Ok("Comment Removed.");
                }
                else
                {
                    commentDeactivateActivate.Is_Active = true;
                    _RangeMatecontext.SaveChanges();
                    return Ok("Comment Activated.");
                }
            }
            catch (Exception)
            {
                return Ok("Could Not Connect To Database");
            }

        }

        // Deactivate/activate Comment
        [HttpPost("DeleteComment/Comment", Name = "DeleteComment")]
        public IActionResult DeleteComment([FromBody] Comment comment)
        {
            // Check if the recived model is valid
            if (!ModelState.IsValid)
            {
                return Ok("Model State Invalid.");
            }

            try
            {
                var commentToDelete = _RangeMatecontext.Comment.First(x => x.Id == comment.Id);
                _RangeMatecontext.Comment.Remove(commentToDelete);
                _RangeMatecontext.SaveChanges();
                return Ok("Comment Deleted.");
            }
            catch (Exception)
            {
                return Ok("Could Not Connect To Database.");
            }

        }
    }
}
