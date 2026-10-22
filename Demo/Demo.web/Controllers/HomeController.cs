using Demo.web.Code;
using Demo.web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;
        public HomeController(IEmailSender emailSender, ILogger<HomeController> logger)
        {
            _emailSender = emailSender;
            _logger= logger;
        }
        public IActionResult Index()
        {
            try
            {

                _logger.LogInformation("sending test email");
                _emailSender.SendEmail("alamin", "welcome", "this is aura");

                return View();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "An error occered while sending email");
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
