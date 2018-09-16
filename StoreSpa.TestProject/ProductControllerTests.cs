using System;
using Xunit;
using Moq;
using WalmartSpa.Services;
using WalmartSpa.Controllers;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WalmartSpa.Models;
using System.Collections.Generic;

namespace StoreSpa.TestProject
{
    public class ProductControllerTests
    { 
        [Fact]
        public async Task ProductSearch_Success()
        {
            var expected = "Results";
            var mock = new Mock<IWalmartApiClient>();
            mock.Setup(x => x.searchProduct("/v1/search?query=marvel"))
                .ReturnsAsync(new HttpResponseMessage() {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    Content = new StringContent("Results", Encoding.UTF8, "application/json")
            });
            var productController = new ProductController(mock.Object);
            var actionResult = await productController.Search("marvel");
            var okObjectResult = actionResult as OkObjectResult;
            Assert.NotNull(okObjectResult);
            Assert.Equal(expected, okObjectResult.Value);
        }
        [Fact]
        public async Task ProductSearch_Fail_EmptyString()
        {
            var expected = 400;
            var mock = new Mock<IWalmartApiClient>();
            mock.Setup(x => x.searchProduct("/v1/search?query="))
                .ReturnsAsync(new HttpResponseMessage()
                {
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Content = new StringContent("error", Encoding.UTF8, "application/json")
                });
            var productController = new ProductController(mock.Object);
            var actionResult = await productController.Search("");
            var badRequestObject = actionResult as BadRequestResult;
            Assert.NotNull(badRequestObject);
            Assert.Equal(expected, badRequestObject.StatusCode);
        }
        [Fact]
        public async Task ProductSearch_Fail_WalmartClientRequest()
        {
            var expected = 400;
            var mock = new Mock<IWalmartApiClient>();
            mock.Setup(x => x.searchProduct("/v1/search?query=marvel"))
                .ReturnsAsync(new HttpResponseMessage()
                {
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Content = new StringContent("error", Encoding.UTF8, "application/json")
                });
            var productController = new ProductController(mock.Object);
            var actionResult = await productController.Search("marvel");
            var badRequestObject = actionResult as BadRequestResult;
            Assert.NotNull(badRequestObject);
            Assert.Equal(expected, badRequestObject.StatusCode);
        }

        [Fact]
        public async Task ProductLookUp_Success()
        {
            var expected = "Results";
            var mock = new Mock<IWalmartApiClient>();
            mock.Setup(x => x.lookUpProduct("/v1/items/12345"))
                .ReturnsAsync(new HttpResponseMessage()
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    Content = new StringContent("Results", Encoding.UTF8, "application/json")
                });
            var productController = new ProductController(mock.Object);
            var actionResult = await productController.LookUp(12345);
            var okObjectResult = actionResult as OkObjectResult;
            Assert.NotNull(okObjectResult);
            Assert.Equal(expected, okObjectResult.Value);
        }
        [Fact]
        public async Task ProductLookUp_Fail_WalmartClientRequest()
        {
            var expected = 400;
            var mock = new Mock<IWalmartApiClient>();
            mock.Setup(x => x.lookUpProduct("/v1/items/12345"))
                .ReturnsAsync(new HttpResponseMessage()
                {
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Content = new StringContent("error", Encoding.UTF8, "application/json")
                });
            var productController = new ProductController(mock.Object);
            var actionResult = await productController.LookUp(12345);
            var badRequestObject = actionResult as BadRequestResult;
            Assert.NotNull(badRequestObject);
            Assert.Equal(expected, badRequestObject.StatusCode);
        }

        [Fact]
        public async Task ProductRecommend_Success()
        {
            var expected = new MockRecommendedResponses().RecommendedProductsJson(10);
            var expectedCount = 10;
            var response = new MockRecommendedResponses().RecommendedProductsJson(25);
            var mock = new Mock<IWalmartApiClient>();
            mock.Setup(x => x.recommendProduct("/v1/nbp?itemId=12345"))
                .ReturnsAsync(new HttpResponseMessage()
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    Content = new StringContent(response, Encoding.UTF8, "application/json")
                });
            var productController = new ProductController(mock.Object);
            var actionResult = await productController.Recommend(12345);
            var okObjectResult = actionResult as OkObjectResult;
            Assert.NotNull(okObjectResult);
            Assert.Equal(expected, okObjectResult.Value);
            Assert.Equal(expectedCount, JsonConvert.DeserializeObject<List<ProductRecommendationModel.RootObject>>(okObjectResult.Value.ToString()).Count);
        }
        [Fact]
        public async Task ProductRecommend_Fail_WalmartClientRequest()
        {
            var expected = 400;
            var mock = new Mock<IWalmartApiClient>();
            mock.Setup(x => x.recommendProduct("/v1/nbp?itemId=12345"))
                .ReturnsAsync(new HttpResponseMessage()
                {
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Content = new StringContent("error", Encoding.UTF8, "application/json")
                });
            var productController = new ProductController(mock.Object);
            var actionResult = await productController.Recommend(12345);
            var badRequestObject = actionResult as BadRequestResult;
            Assert.NotNull(badRequestObject);
            Assert.Equal(expected, badRequestObject.StatusCode);
        }
    }
}
