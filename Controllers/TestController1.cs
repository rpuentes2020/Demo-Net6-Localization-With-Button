using DemoLocalization.Resources;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace DemoLocalization.Controllers
{
    public class TestController1 : Controller
        {

        private readonly IStringLocalizer<SharedResource> _loc;

        public TestController1(IStringLocalizer<SharedResource> loc)
        {
            _loc = loc;
        }

        [HttpGet ("GetValue")]

        public IActionResult Index()
        {
            var test = _loc.GetString("WelcomeMessage").Value;


            return View();
        }
    }
}
