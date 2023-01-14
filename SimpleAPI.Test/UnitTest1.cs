using Microsoft.Extensions.Logging;
using SimpleAPI;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController weatherForecastController = new WeatherForecastController();
        [Fact]
        public void GetReturnMyName()
        {
            var returnValue = weatherForecastController.Get(1);
            Assert.True(returnValue != null);
            Assert.Equal("Adebayo Ishola", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}