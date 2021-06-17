using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ModelLibrary;
using RangeMate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly RangeMateContext _RangeMatecontext;
        // Encryption
        private readonly EncryptionService _encryptionService;

        public LoginController(RangeMateContext RangeMatecontext, EncryptionService encryptionService)
        {
            _RangeMatecontext = RangeMatecontext;
            // Encryption
            _encryptionService = encryptionService;
        }

        [HttpPost("Login", Name = "Login")]
        public IActionResult LoginCheck([FromBody] User user)
        {
            // Check if the recived model is valid
            if (!ModelState.IsValid)
            {
                return Ok("Model State Invalid.");
            }
            // Check user input email
            try
            {
                string ValidateEmail = new MailAddress(user.Email).Address;
            }
            catch (Exception)
            {
                //If any part of the validation return NotFound
                return NotFound();
            }

            try
            {
                // Check if user exists
                User checkUser = _RangeMatecontext.User.SingleOrDefault(x => x.Email == user.Email);
                if (checkUser != null)
                {
                    // Check provided password against the DB stored hashed password
                    if (BC.Verify(user.Password, checkUser.Password))
                    {
                        //Update LastLogin
                        checkUser.LastLogin = DateTime.Now;
                        _RangeMatecontext.SaveChanges();

                        //Remove Hashed password from returned object.
                        checkUser.Password = "";
                        // Decrypt name and lastname
                        checkUser.FirstName = _encryptionService.Decrypt(checkUser.FirstName);
                        checkUser.LastName = _encryptionService.Decrypt(checkUser.LastName);

                        // return user object 
                        return Ok(checkUser); ;
                    }
                    //If any part of the validation return NotFound
                    else return NotFound();
                }
                //If any part of the validation return NotFound
                else return NotFound();
            }
            catch (Exception)
            {
                return Ok("Could Not Connect To Database.");
            }
        }
    }
}
