using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website.Services.Base;
using ModelLibrary;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;

namespace Website.Services
{
    public class LoginServices : BaseService
    {

        public LoginServices(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<User> AttemptLogin(User user)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Login/Login";
                var content = new StringContent(JsonConvert.SerializeObject(user), System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(endPoint, content);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var userLoggingIn = JsonConvert.DeserializeObject<User>(result);

                    return userLoggingIn;

                }
                return user;
            }
            catch (Exception)
            {
                // If no answer from database return the object
                return user;
            }
        }
    }
}
