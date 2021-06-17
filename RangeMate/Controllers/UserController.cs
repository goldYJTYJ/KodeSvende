using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using ModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly RangeMateContext _RangeMatecontext;

        private readonly EncryptionService _encryptionService;

        public UserController(RangeMateContext RangeMatecontext, EncryptionService encryptionService)
        {
            _RangeMatecontext = RangeMatecontext;

            _encryptionService = encryptionService;
        }

        [HttpPost("CreateUser", Name = "CreateUser")]
        public IActionResult CreateUser([FromBody] User user)
        {
            try
            {
                // Check if the recived model is valid
                if (!ModelState.IsValid)
                {
                    return Ok("Model State Invalid.");
                }

                // Check if user exists
                User checkUser = _RangeMatecontext.User.SingleOrDefault(x => x.Email == user.Email);
                if (checkUser != null)
                {
                    return Ok("A user with this e-mail exists.");
                }
                else
                {
                    user.FirstName = _encryptionService.Encrypt(user.FirstName);
                    user.LastName = _encryptionService.Encrypt(user.LastName);
                    // set data for new user
                    _RangeMatecontext.User.Add(user);
                    _RangeMatecontext.SaveChanges();
                    User newUser = _RangeMatecontext.User.SingleOrDefault(x => x.Email == user.Email);
                    newUser.Password = BCrypt.Net.BCrypt.HashPassword(newUser.Password);
                    newUser.AccountCreation = DateTime.Now;
                    newUser.Is_Active = true;
                    _RangeMatecontext.SaveChanges();
                    return Ok("User has been created");
                }
            }
            catch (Exception)
            {
                // if database connection fails return error
                return Ok("Could Not Connect To Database.");
            }
        }

        [HttpPost("EditUser", Name = "EditUser")]
        public IActionResult EditUser([FromBody] User user)
        {
            try
            {
                // Check if the recived model is valid
                if (!ModelState.IsValid)
                {
                    return Ok("Model State Invalid.");
                }

                //finde current user trying to edit
                User UserFromDb = _RangeMatecontext.User.FirstOrDefault(x => x.Id == user.Id);
                if (UserFromDb == null)
                {
                    return Ok("User not found.");
                }

                if (!BC.Verify(user.Password, UserFromDb.Password))
                {
                    return Ok("Password was incorret.");
                }

                var AllUsersFromDb = _RangeMatecontext.User.ToList();
                AllUsersFromDb.RemoveAll(x => x.Id == user.Id);
                if (AllUsersFromDb.Any(us => us.Email.ToLower() == user.Email.ToLower()))
                {
                    return Ok("email is already taken.");
                }
                else
                {
                    UserFromDb.FirstName = _encryptionService.Encrypt(user.FirstName);
                    UserFromDb.LastName = _encryptionService.Encrypt(user.LastName);
                    UserFromDb.Email = user.Email;
                    _RangeMatecontext.SaveChanges();
                    return Ok("User has been updated.");
                }
            }
            catch (Exception)
            {
                // if database connection fails return error
                return Ok("Could Not Connect To Database.");
            }
        }

        [HttpPost("AdminEditUser", Name = "AdminEditUser")]
        public IActionResult AdminEditUser([FromBody] List<string> UserInfo)
        {
            try
            {
                // Check if the recived model is valid
                if (!ModelState.IsValid)
                {
                    return Ok("Model State Invalid.");
                }

                User user = new User
                {
                    Id = Int32.Parse(UserInfo[0]),
                    FirstName = UserInfo[1],
                    LastName = UserInfo[2],
                    Email = UserInfo[3]
                };

                //finde current user trying to edit
                User UserFromDb = _RangeMatecontext.User.FirstOrDefault(x => x.Id == user.Id);
                if (UserFromDb == null)
                {
                    return Ok("User not found.");
                }

                var AllUsersFromDb = _RangeMatecontext.User.ToList();
                AllUsersFromDb.RemoveAll(x => x.Id == user.Id);
                if (AllUsersFromDb.Any(us => us.Email.ToLower() == user.Email.ToLower()))
                {
                    return Ok("email is already taken.");
                }
                else
                {
                    UserFromDb.FirstName = _encryptionService.Encrypt(user.FirstName);
                    UserFromDb.LastName = _encryptionService.Encrypt(user.LastName);
                    UserFromDb.Email = user.Email;
                    _RangeMatecontext.SaveChanges();
                    return Ok("User has been updated.");
                }
            }
            catch (Exception)
            {
                // if database connection fails return error
                return Ok("Could Not Connect To Database.");
            }
        }

        [HttpPost("AdminUpdatePassword", Name = "AdminUpdatePassword")]
        public IActionResult AdminUpdatePassword([FromBody] List<string> UserInfo)
        {
            try
            {
                // Check if the recived model is valid
                if (!ModelState.IsValid)
                {
                    return Ok("Model State Invalid.");
                }

                User user = new User
                {
                    Id = Int32.Parse(UserInfo[0]),
                    Password = UserInfo[1]
                };

                //finde current user trying to edit
                User UserFromDb = _RangeMatecontext.User.FirstOrDefault(x => x.Id == user.Id);
                if (UserFromDb == null)
                {
                    return Ok("User not found.");
                }

                UserFromDb.Password = BC.HashPassword(user.Password);
                _RangeMatecontext.SaveChanges();
                return Ok("User has gotten the password updated.");
            }
            catch (Exception)
            {
                // if database connection fails return error
                return Ok("Could Not Connect To Database.");
            }
        }

        [HttpPost("UpdatePassword", Name = "UpdatePassword")]
        public IActionResult UpdatePassword([FromBody] List<string> UserInfo)
        {
            try
            {
                // Check if the recived model is valid
                if (!ModelState.IsValid)
                {
                    return Ok("Model State Invalid.");
                }

                User user = new User
                {
                    Id = Int32.Parse(UserInfo[0]),
                    Password = UserInfo[1]
                };

                //finde current user trying to edit
                User UserFromDb = _RangeMatecontext.User.FirstOrDefault(x => x.Id == user.Id);
                if (UserFromDb == null)
                {
                    return Ok("User not found.");
                }

                if (!BC.Verify(UserInfo[2], UserFromDb.Password))
                {
                    return Ok("Old Password was incorret.");
                }

                UserFromDb.Password = BC.HashPassword(user.Password);
                _RangeMatecontext.SaveChanges();
                return Ok("Your password has been updated.");
            }
            catch (Exception)
            {
                // if database connection fails return error
                return Ok("Could Not Connect To Database.");
            }
        }


        [HttpGet("{UserID}", Name = "GetUser")]
        public IActionResult GetUser([FromQuery] int UserID)
        {
            try
            {
                // Check if the recived model is valid
                if (!ModelState.IsValid)
                {
                    return Ok("Model State Invalid.");
                }

                //finde user on id
                User UserToReturn = _RangeMatecontext.User.FirstOrDefault(x => x.Id == UserID);
                if (UserToReturn == null)
                {
                    return Ok("User not found.");
                }
                UserToReturn.Password = "Temp@hotmail.com";
                UserToReturn.FirstName = _encryptionService.Decrypt(UserToReturn.FirstName);
                UserToReturn.LastName = _encryptionService.Decrypt(UserToReturn.LastName);
                return Ok(UserToReturn);
            }
            catch (Exception)
            {
                // if database connection fails return error
                return Ok("Could Not Connect To Database.");
            }
        }

        [HttpPost("AdminDeactivateAndActivateUser", Name = "AdminDeactivateAndActivateUser")]
        public IActionResult AdminDeactivateAndActivateUser([FromBody] int UserID)
        {
            try
            {
                // Check if the recived model is valid
                if (!ModelState.IsValid)
                {
                    return Ok("Model State Invalid.");
                }

                //finde current user trying to edit
                User UserFromDb = _RangeMatecontext.User.FirstOrDefault(x => x.Id == UserID);
                if (UserFromDb == null)
                {
                    return Ok("User not found.");
                }

                if (UserFromDb.Is_Active == true)
                {
                    UserFromDb.Is_Active = false;
                    _RangeMatecontext.SaveChanges();
                    return Ok("User has been changed to InActive.");
                }
                else
                {
                    UserFromDb.Is_Active = true;
                    _RangeMatecontext.SaveChanges();
                    return Ok("User has been changed to Active.");
                }
            }
            catch (Exception)
            {
                // if database connection fails return error
                return Ok("Could Not Connect To Database.");
            }
        }

        [HttpPost("DeactivateUser", Name = "DeactivateUser")]
        public IActionResult DeactivateUser([FromBody] User user)
        {
            try
            {
                // Check if the recived model is valid
                if (!ModelState.IsValid)
                {
                    return Ok("Model State Invalid.");
                }

                //finde current user trying to deactivate
                User UserFromDb = _RangeMatecontext.User.FirstOrDefault(x => x.Id == user.Id);
                if (UserFromDb == null)
                {
                    return Ok("User not found.");
                }

                if (!BC.Verify(user.Password, UserFromDb.Password))
                {
                    return Ok("Password was incorret.");
                }

                if (UserFromDb.Is_Active == true)
                {
                    UserFromDb.Is_Active = false;
                    _RangeMatecontext.SaveChanges();
                    return Ok("User has been changed to InActive.");
                }

                return Ok("User deaktivation failed.");
            }
            catch (Exception)
            {
                // if database connection fails return error
                return Ok("Could Not Connect To Database.");
            }
        }

        [HttpGet("AdminGetAllUser", Name = "AdminGetAllUser")]
        public IActionResult AdminGetAllUser()
        {
            try
            {
                //finde current user trying to deactivate
                List<User> UserFromDb = _RangeMatecontext.User.ToList();
                if (UserFromDb == null)
                {
                    return Ok("Users not found.");
                }

                foreach (var item in UserFromDb)
                {
                    item.FirstName = _encryptionService.Decrypt(item.FirstName);
                    item.LastName = _encryptionService.Decrypt(item.LastName);
                }

                return Ok(UserFromDb.OrderBy(x => x.Email));
            }
            catch (Exception)
            {
                // if database connection fails return error
                return Ok("Could Not Connect To Database.");
            }
        }
    }
}
