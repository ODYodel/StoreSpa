using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalmartSpa.Models;
using WalmartSpa.Services;

namespace WalmartSpa.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IWalmartApiClient _walmartApiClient;

        public ProductController (IWalmartApiClient walmartApiClient)
        {
            _walmartApiClient = walmartApiClient;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> Search(string product)
        {
            var results = "";
            if (String.IsNullOrEmpty(product))
            {
                return BadRequest();
            }
            var response = await _walmartApiClient.searchProduct($"/v1/search?query={product}");
            if (response.IsSuccessStatusCode)
            {
                results = await response.Content.ReadAsStringAsync();
            } else
            {
                return BadRequest();
            }
            return Ok(results);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> LookUp(int itemId)
        {
            var results = "";
            var response = await _walmartApiClient.lookUpProduct($"/v1/items/{itemId}");
            if (response.IsSuccessStatusCode)
            {
                results = await response.Content.ReadAsStringAsync();
            }
            else
            {
                return BadRequest();
            }
            return Ok(results);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> Recommend(int itemId)
        {
            var results = "";
            List<ProductRecommendationModel.RootObject> product;
            var response = await _walmartApiClient.recommendProduct($"/v1/nbp?itemId={itemId}");
            if (response.IsSuccessStatusCode)
            {
                results = await response.Content.ReadAsStringAsync();
                product = JsonConvert.DeserializeObject<List<ProductRecommendationModel.RootObject>>(results);
                var topTenRecommendedProducts = product.Take(10).ToList();
                return Ok(JsonConvert.SerializeObject(topTenRecommendedProducts));
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
