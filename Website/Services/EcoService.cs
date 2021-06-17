using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Website.Services.Base;
using System.Net.Http;
using Newtonsoft.Json;
using ModelLibrary;
using ModelLibrary.DTO;

namespace Website.Services
{
    public class EcoService : BaseService
    {
        public EcoService(IConfiguration configuration) : base(configuration)
        {
        }

        // Get ICE economy summary, takes parameter engine ID
        public async Task<string> GetSummaryICE(int EngineID)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Eco/GetEcoSummaryICE/?EngineID=" + EngineID;
                var content = await client.GetStringAsync(endPoint);

                return content;
            }
            catch (Exception)
            {
                // Database connection failed return empty object
                return "Could Not Connect To API";
            }
        }

        // Get list of economy reports, takes parameter engine ID
        public async Task<string> GetEcoICEList(int EngineID)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Eco/GetEcoListICE/" + EngineID;
                var content = await client.GetStringAsync(endPoint);
                return content;
            }
            catch (Exception)
            {
                // Database connection failed return empty object
                return "Could Not Connect To API";
            }
        }

        // Create ecnomomy report for ICE, takes parameter EconomyReportICE Object 
        public async Task<string> CreateICEReport(EconomyReportICE EcoReport)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Eco/CreateReport/ICE";
                var content = new StringContent(JsonConvert.SerializeObject(EcoReport), System.Text.Encoding.UTF8, "application/json");
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

        // Update ICE report, takes parameter EconomyReportICE object
        public async Task<string> UpdateICEReport(EconomyReportICE EcoReport)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Eco/UpdateReport/ICE";
                var content = new StringContent(JsonConvert.SerializeObject(EcoReport), System.Text.Encoding.UTF8, "application/json");
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

        // Get economy summary for electric car, takes parameter engine ID
        public async Task<string> GetSummaryElectric(int EngineID)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Eco/GetEcoSummaryElectric/" + EngineID;
                var content = await client.GetStringAsync(endPoint);
                return content;
            }
            catch (Exception)
            {
                // Database connection failed return empty object
                return "Could Not Connect To API";
            }
        }

        // Get list of all economy reports, takes parameter Engine ID
        public async Task<string> GetEcoListElectric(int EngineID)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Eco/GetEcoListElectric/" + EngineID;
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

        // Create economy report for electric car, takes parameter EconomyReportElectic Object
        public async Task<string> CreateElectricReport(EconomyReportElectric EcoReport)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Eco/CreateReport/Electric";

                var content = new StringContent(JsonConvert.SerializeObject(EcoReport), System.Text.Encoding.UTF8, "application/json");
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

        // Update economy report for electic car, takes parameter  EconomyReportElectric Object
        public async Task<string> UpdateElectricReport(EconomyReportElectric EcoReport)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Eco/UpdateReport/Electric";
                var content = new StringContent(JsonConvert.SerializeObject(EcoReport), System.Text.Encoding.UTF8, "application/json");
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

        // Get Car information, takes parameter EngineID
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
