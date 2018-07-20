using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "55555555";
        }

        public string Address()
        {
            return "USA";
        }
    }
}