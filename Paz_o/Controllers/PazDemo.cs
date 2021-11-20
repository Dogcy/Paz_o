using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Paz_o.Controllers
{
    public class PazDemo : Controller
    {

        private readonly ILogger<PazDemo> _logger;

        public PazDemo(ILogger<PazDemo> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
