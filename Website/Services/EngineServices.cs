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
    public class EngineServices : BaseService
    {
        public EngineServices(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<string> GetEngineListAdmin(int ModelID)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Engine/GetEngineListAdmin/" + ModelID;
                var result = await client.GetStringAsync(endPoint);
                return result;
            }
            catch (Exception)
            {
                // Database connection failed return empty object
                return "Could Not Connect To API";
            }
        }

        public async Task<string> UpdateEngine(Engine engine)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Engine/UpdateEngine";

                var content = new StringContent(JsonConvert.SerializeObject(engine), System.Text.Encoding.UTF8, "application/json");
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

        public async Task<string> CreateEngine(Engine engine)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Engine/CreateEngine";

                var content = new StringContent(JsonConvert.SerializeObject(engine), System.Text.Encoding.UTF8, "application/json");
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