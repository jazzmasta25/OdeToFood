using Microsoft.Extensions.Configuration;

namespace OdeToFood.Services
{
    public class Greeter : IGreeter
    {
        private IConfiguration _configration;

        public Greeter(IConfiguration configuration)
        {
            _configration = configuration;
        }
        public string GetMessageOfTheDay()
        {
            return _configration["Greeting"];

        }
    }
}