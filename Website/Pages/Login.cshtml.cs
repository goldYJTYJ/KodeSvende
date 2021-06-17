using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using ModelLibrary;
using Newtonsoft.Json;
using Website.Services;

namespace Website.Pages
{

    public class LoginModel : PageModel
    {
        readonly IConfiguration configuration;
        public LoginModel(IConfiguration config)
        {
            this.configuration = config;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }

        public string ShowError { get; set; }

        public static IConfigurationRoot Configuration { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            // Create User object from user input
            User UserToLogin = new User
            {
                Email = Input.Email,
                Password = Input.Password
            };

            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Unused) { Content = new StringContent("No Response from API") };

            try
            {
                // Create Http client and connect to API login
                using var client = new HttpClient();
                var endPoint = configuration["IP:API"] + "/api/Login/Login";
                var content = new StringContent(JsonConvert.SerializeObject(UserToLogin), System.Text.Encoding.UTF8, "application/json");
                response = await client.PostAsync(endPoint, content);
                var result = await response.Content.ReadAsStringAsync();

                // If connection fails, provide error.
                if (response.StatusCode == HttpStatusCode.Unused)
                {
                    ShowError = "No Response from API";
                    return null;
                }
                else if (result == "Could Not Connect To Database")
                {
                    ShowError = result;
                }
            }
            catch (Exception)
            {
                ShowError = "Could Not Connect To API";
            }

            try
            {
                // If server indicates the login is successful
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var userLoggingIn = JsonConvert.DeserializeObject<User>(result);

                    // Check for empty user object
                    if (userLoggingIn.Id != 0)
                    {
                        // Check if user is active
                        if (userLoggingIn.Is_Active == true)
                        {
                            // Check if user is an administrator
                            if (userLoggingIn.Is_Administrator == true)
                            {
                                // Create claims for administrator
                                var claims = new List<Claim>
                            {
                                new Claim("Id", userLoggingIn.Id.ToString()),
                                new Claim("Email", userLoggingIn.Email.ToString()),
                                new Claim(ClaimTypes.Name, userLoggingIn.FirstName),
                                new Claim("LastName", userLoggingIn.LastName.ToString()),
                                new Claim(ClaimTypes.Role, "Administrator"),
                                new Claim("AccountCreation", userLoggingIn.AccountCreation.ToString()),
                                new Claim("LastLogin", userLoggingIn.LastLogin.ToString())
                            };

                                // Create claim instance with cookie authetication
                                var claimsIdentity = new ClaimsIdentity(
                                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                                // Create new authentication properties, we are using a automatic timeout of 15 minutes.
                                var authProperties = new AuthenticationProperties
                                {
                                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(15),
                                };

                                // Save the logged in users information in a cookie
                                await HttpContext.SignInAsync(
                                CookieAuthenticationDefaults.AuthenticationScheme,
                                new ClaimsPrincipal(claimsIdentity),
                                authProperties);

                                return Redirect("/Index");
                            }
                            else
                            {
                                // Create claims for user
                                var claims = new List<Claim>
                            {
                                new Claim("Id", userLoggingIn.Id.ToString()),
                                new Claim("Email", userLoggingIn.Email.ToString()),
                                new Claim(ClaimTypes.Name, userLoggingIn.FirstName),
                                new Claim("LastName", userLoggingIn.LastName.ToString()),
                                new Claim(ClaimTypes.Role, "User"),
                                new Claim("AccountCreation", userLoggingIn.AccountCreation.ToString()),
                                new Claim("LastLogin", userLoggingIn.LastLogin.ToString()),
                                new Claim("IsUserAktive", userLoggingIn.Is_Active.ToString())
                            };

                                // Create claim instance with cookie authetication
                                var claimsIdentity = new ClaimsIdentity(
                                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                                // Create new authentication properties, we are using a automatic timeout of 15 minutes.
                                var authProperties = new AuthenticationProperties
                                {
                                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(15),
                                };

                                // Save the logged in users information in a cookie
                                await HttpContext.SignInAsync(
                                CookieAuthenticationDefaults.AuthenticationScheme,
                                new ClaimsPrincipal(claimsIdentity),
                                authProperties);
                                return Redirect("/Index");
                            }
                        }
                        else
                        {
                            ShowError = "This user has been disabled, please contact an administrator for more information.";
                        }
                    }
                    else
                    {
                        ShowError = "An unknown error has occurred, please try again.";
                    }
                }
                else
                {
                    ShowError = "User not found, please try again.";
                }

                // Make no changes to the page
                return null;
            }
            catch (Exception)
            {
                ShowError = "An unknown error has occurred. Please contact an administrator.";
                return null;
            }
        }

    }

}
