using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WalmartSpa.Models;

namespace WalmartSpa.Services
{
    public interface IWalmartApiClient
    {
        Task<HttpResponseMessage> searchProduct(string query);
        Task<HttpResponseMessage> lookUpProduct(string query);
        Task<HttpResponseMessage> recommendProduct(string query);
    }
    public class WalmartApiClient : IWalmartApiClient
    {
        private readonly HttpClient _client;
        protected IConfiguration Configuration { get; set; }
        protected static string ApiKey { get; set; }

        public WalmartApiClient(IConfiguration config, HttpClient client)
        {
            _client = client;
            Configuration = config;
            ApiKey = Configuration["WalMartOpenAPIKey"];

        }

        public async Task<HttpResponseMessage> searchProduct(string query)
        {
            query = $"{query}&apiKey={ApiKey}";
            HttpResponseMessage response = await _client.GetAsync(query);
            return response;
        }
        public async Task<HttpResponseMessage> lookUpProduct(string query)
        {
            query = $"{query}?apiKey={ApiKey}";
            HttpResponseMessage response = await _client.GetAsync(query);
            return response;
        }

        public async Task<HttpResponseMessage> recommendProduct(string query)
        {
            query = $"{query}&apiKey={ApiKey}";
            HttpResponseMessage response = await _client.GetAsync(query);
            return response;
        }
    }
}
