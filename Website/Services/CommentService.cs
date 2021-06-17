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
    public class CommentService : BaseService
    {
        public CommentService(IConfiguration configuration) : base(configuration)
        {
        }

        // Get Comments for a model, takes parameter its modelID
        public async Task<string> GetComments(int ModelID)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Comment/Get/Comments/" + ModelID;
                var content = await client.GetStringAsync(endPoint);

                return content;
            }
            catch (Exception)
            {
                return "Could Not Connect To API";
            }
        }

        // Create new comment for model, takes parameter comment object 
        public async Task<string> CreateComment(Comment comment)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Comment/Create/Comment/";
                var content = new StringContent(JsonConvert.SerializeObject(comment), System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(endPoint, content);
                var result = await response.Content.ReadAsStringAsync();

                return result;
            }
            catch (Exception)
            {
                return "Could Not Connect To API";
            }
        }

        // Deactivate or activate comment, takes parameter comment object
        public async Task<string> DeactivateActivateComment(Comment comment)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Comment/DeactivateActivateComment/Comment/";
                var content = new StringContent(JsonConvert.SerializeObject(comment), System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(endPoint, content);
                var result = await response.Content.ReadAsStringAsync();

                return result;
            }
            catch (Exception)
            {
                return "Could Not Connect To API";
            }
        }

        // Delete comment, takes parameter comment object
        public async Task<string> DeleteComment(Comment comment)
        {
            try
            {
                using var client = new HttpClient();
                var endPoint = ApiIP + "/api/Comment/DeleteComment/Comment/";
                var content = new StringContent(JsonConvert.SerializeObject(comment), System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(endPoint, content);
                var result = await response.Content.ReadAsStringAsync();

                return result;
            }
            catch (Exception)
            {
                return "Could Not Connect To API";
            }
        }

    }
}
