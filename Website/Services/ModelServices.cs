using Microsoft.Extensions.Configuration;
using ModelLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Website.Services.Base;

namespace Website.Services
{
    public class ModelServices : BaseService
    {
        public ModelServices(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<string> GetModelListAdmin(int ManufacturerID)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Model/GetModelListAdmin/" + ManufacturerID;
                var content = await client.GetStringAsync(endPoint);
                return content;
            }
            catch (Exception)
            {
                // Database connection failed return empty object
                return "Could Not Connect To API";
            }
        }

        public async Task<string> UpdateModel(Model model)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Model/UpdateModel";

                var content = new StringContent(JsonConvert.SerializeObject(model), System.Text.Encoding.UTF8, "application/json");
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

        public async Task<string> CreateModel(Model model)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Model/CreateModel";

                var content = new StringContent(JsonConvert.SerializeObject(model), System.Text.Encoding.UTF8, "application/json");
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
    }
}