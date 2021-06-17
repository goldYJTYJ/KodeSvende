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
    public class ManufacturerServices : BaseService
    {
        public ManufacturerServices(IConfiguration configuration) : base(configuration)
        {
        }

        // Get all Manufacturers 
        public async Task<string> GetManufacturerListAdmin()
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Manufacturer/GetManufacturerListAdmin";
                var content = await client.GetStringAsync(endPoint);
                return content;
            }
            catch (Exception)
            {
                // Database connection failed return error
                return "Could Not Connect To API";
            }
        }

        public async Task<string> UpdateManfacturer(Manufacturer manufacturer)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Manufacturer/UpdateManfacturer";

                var content = new StringContent(JsonConvert.SerializeObject(manufacturer), System.Text.Encoding.UTF8, "application/json");
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

        public async Task<string> CreateManfacturer(Manufacturer manufacturer)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Manufacturer/CreateManfacturer";

                var content = new StringContent(JsonConvert.SerializeObject(manufacturer), System.Text.Encoding.UTF8, "application/json");
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
