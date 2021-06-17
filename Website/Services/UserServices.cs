using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website.Services.Base;
using Microsoft.Extensions.Configuration;
using ModelLibrary;
using System.Net.Http;
using Newtonsoft.Json;

namespace Website.Services
{
    public class UserServices : BaseService
    {
        public UserServices(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<string> CreateUser(User User)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/User/CreateUser";

                var content = new StringContent(JsonConvert.SerializeObject(User), System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(endPoint, content);
                var result = await response.Content.ReadAsStringAsync();
                return result;
            }
            catch (Exception)
            {
                // Database connection failed return empty object
                return "Could Not Connect To API";
            }
        }

        public async Task<string> EditUser(User User)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/User/EditUser";

                var content = new StringContent(JsonConvert.SerializeObject(User), System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(endPoint, content);
                var result = await response.Content.ReadAsStringAsync();
                return result;
            }
            catch (Exception)
            {
                // Database connection failed return empty object
                return "Could Not Connect To API";
            }
        }

        public async Task<string> AdminEditUser(int Id, string Firstname, string Lastname, string Email)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/User/AdminEditUser";

                List<string> ThingsToSend = new List<string>
                {
                    Id.ToString(),
                    Firstname,
                    Lastname,
                    Email
                };

                var content = new StringContent(JsonConvert.SerializeObject(ThingsToSend), System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(endPoint, content);
                var result = await response.Content.ReadAsStringAsync();
                return result;
            }
            catch (Exception)
            {
                // Database connection failed return empty object
                return "Could Not Connect To API";
            }
        }

        public async Task<string> AdminUpdatePassword(int Id, string Password)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/User/AdminUpdatePassword";

                List<string> ThingsToSend = new List<string>
                {
                    Id.ToString(),
                    Password
                };

                var content = new StringContent(JsonConvert.SerializeObject(ThingsToSend), System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(endPoint, content);
                var result = await response.Content.ReadAsStringAsync();
                return result;
            }
            catch (Exception)
            {
                // Database connection failed return empty object
                return "Could Not Connect To API";
            }
        }

        public async Task<string> UpdatePassword(int Id, string Password, string OldPassword)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/User/UpdatePassword";

                List<string> ThingsToSend = new List<string>
                {
                    Id.ToString(),
                    Password,
                    OldPassword
                };

                var content = new StringContent(JsonConvert.SerializeObject(ThingsToSend), System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(endPoint, content);
                var result = await response.Content.ReadAsStringAsync();
                return result;
            }
            catch (Exception)
            {
                return "Could Not Connect To API";
            }
        }

        public async Task<string> DeactivateUser(User User)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/User/DeactivateUser";

                var content = new StringContent(JsonConvert.SerializeObject(User), System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(endPoint, content);
                var result = await response.Content.ReadAsStringAsync();
                return result;
            }
            catch (Exception)
            {
                return "Could Not Connect To API";
            }
        }

        public async Task<string> AdminDeactivateAndActivateUser(int UserID)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/User/AdminDeactivateAndActivateUser";

                var content = new StringContent(JsonConvert.SerializeObject(UserID), System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(endPoint, content);
                var result = await response.Content.ReadAsStringAsync();
                return result;
            }
            catch (Exception)
            {
                return "Could Not Connect To API";
            }
        }

        public async Task<User> GetUser(int UserID)
        {
            using var client = new HttpClient();
            try
            {
                var endPoint = ApiIP + "/api/User/GetUser/?UserID=" + UserID;
                var response = await client.GetAsync(endPoint);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var UserFromServer = JsonConvert.DeserializeObject<User>(result);
                    return UserFromServer;
                }
                else
                {
                    User UserToReturnOnError = new User
                    {
                        FirstName = "Unknow Error From Get User"
                    };
                    return UserToReturnOnError;
                }
            }
            catch (Exception)
            {
                User UserToReturnOnError = new User
                {
                    FirstName = "Database not found."
                };
                return UserToReturnOnError;
                throw;
            }
        }

        public async Task<string> AdminGetAllUser()
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/User/AdminGetAllUser";
                var Content = await client.GetStringAsync(endPoint);
                //var UsersFromServer = JsonConvert.DeserializeObject<List<User>>(result);
                return Content;
            }
            catch (Exception)
            {
                return "Could Not Connect To API";
            }
        }
    }
}
