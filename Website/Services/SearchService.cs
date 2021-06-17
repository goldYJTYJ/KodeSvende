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
    public class SearchService : BaseService
    {
        public SearchService(IConfiguration configuration) : base(configuration)
        {
        }

        // Get all Manufacturers takes no parameters
        public async Task<string> GetManufacturerList()
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Search/GetManufacturerList";
                var content = await client.GetStringAsync(endPoint);
                return content;
            }
            catch (Exception)
            {
                // Database connection failed return error
                return "Could Not Connect To API";
            }
        }

        // Get all models takes parameter ManufacturerID  
        public async Task<string> GetModelList(int ManufacturerID)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Search/GetModelList/?ManufacturerID=" + ManufacturerID;
                var content = await client.GetStringAsync(endPoint);
                return content;
            }
            catch (Exception)
            {
                // Database connection failed return empty object
                return "Could Not Connect To API";
            }
        }

        // Get all engines takes parameter modelID 
        public async Task<string> GetEngineList(int ModelID)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Search/GetEngineList/" + ModelID;
                var content = await client.GetStringAsync(endPoint);
                return content;
                //return JsonConvert.DeserializeObject<List<Engine>>(content);
            }
            catch (Exception)
            {
                // Database connection failed return empty object
                return "Could Not Connect To API";
            }
        }

        // Get manufacturer takes parameter manufacturerID
        public async Task<string> GetManufacturer(int ManufacturerID)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Search/Get/Manufacturer/" + ManufacturerID;
                var content = await client.GetStringAsync(endPoint);
                return content;
            }
            catch (Exception)
            {
                // Database connection failed return empty object
                return "Could Not Connect To API";
            }
        }

        // Get car information takes parameter engine ID 
        public async Task<string> GetCarInformation(int EngineID)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Eco/GetCarInformation/" + EngineID;
                var content = await client.GetStringAsync(endPoint);

                return content;
            }
            catch (Exception)
            {
                // Database connection failed return empty object
                return "Could Not Connect To API";
            }
        }
    }
}
