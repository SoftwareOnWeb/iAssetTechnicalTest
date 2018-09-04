using Microsoft.VisualStudio.TestTools.UnitTesting;
using iAssetTechnicalTest_MVCWebAPI_4Dot5.Controllers;
using iAssetTechnicalTest_MVCWebAPI_4Dot5.Models;
using iAssetTechnicalTest_MVCWebAPI_4Dot5.Service;

namespace iAssetTechnicalTest_MVCWebAPI_4Dot5.Tests.Controllers
{
    [TestClass]
    public class WeatherControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            WeatherController controller = new WeatherController(new WeatherService());
            WeatherFilter weatherFilter = new WeatherFilter() { Country = "US", City = "Abbeville" };
            // Act
            WeatherDataVIewModel weatherDataVIewModel = controller.Get(weatherFilter);
            // Assert
            Assert.IsNotNull(weatherDataVIewModel);
            Assert.AreEqual(weatherFilter.Country, weatherDataVIewModel.Country);
            Assert.AreEqual(weatherFilter.City, weatherDataVIewModel.City);
        }
    }
}
