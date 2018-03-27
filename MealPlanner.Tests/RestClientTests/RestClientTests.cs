using MealPlanner.Entities;
using MealPlanner.Services.Interfaces;
using MealPlannerClient;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using Xunit;

namespace MealPlanner.Tests.RestClientTests
{
    public class RestClientTests
    {
        private Uri uri = new Uri("http://localhost:5000");

        [Fact]
        public void GetAllMealsAsync_ReturnsAllMeals()
        {
            var meals = JsonConvert.SerializeObject(MealsTestData());

            var mockHttpHandler = new Mock<IHttpHandler>();
            mockHttpHandler.Setup(x => x.GetAsync(It.IsAny<string>()))
                .ReturnsAsync(Success(meals));

            var client = new RestClient<Meal>(uri, mockHttpHandler.Object);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;

            var result = client.GetMeals(token).Result;

            Assert.NotNull(result);
        }

        private List<Meal> MealsTestData()
        {
            return new List<Meal>
            {
                new Meal { Id = 1, Name = "Meal 1" },
                new Meal { Id = 2, Name = "Meal 2" },
                new Meal { Id = 3, Name = "Meal 3" }
            };
        }

        private static HttpResponseMessage Success(string content)
        {
            var response = new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent(content)
            };
            return response;
        }
    }
}

