using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using WalmartSpa.Models;

namespace StoreSpa.TestProject
{
    public class MockRecommendedResponses
    {
        public List<ProductRecommendationModel.RootObject> RecommendedProducts(int numberOfRecommendations)
        {
            var listOfRecommednations = new List<ProductRecommendationModel.RootObject>();
            for(var i = 0; i < numberOfRecommendations; i++)
            {
                var newRecommednation = createNewRecommendation();
                listOfRecommednations.Add(newRecommednation);
            }
            return listOfRecommednations;
        }
        public string RecommendedProductsJson(int numberOfRecommendations)
        {
            var listOfRecommednations = new List<ProductRecommendationModel.RootObject>();
            for (var i = 0; i < numberOfRecommendations; i++)
            {
                var newRecommednation = createNewRecommendation();
                listOfRecommednations.Add(newRecommednation);
            }
            var jsonListofRecommednations = JsonConvert.SerializeObject(listOfRecommednations);
            return jsonListofRecommednations;
        }
        protected ProductRecommendationModel.RootObject createNewRecommendation()
        {
            var recommendation = new ProductRecommendationModel.RootObject();
            return recommendation;

        }
    }
}
