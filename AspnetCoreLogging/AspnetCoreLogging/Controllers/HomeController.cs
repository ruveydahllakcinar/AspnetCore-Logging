using AspnetCoreLogging.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspnetCoreLogging.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 1.yol
        /// </summary>
        /// <returns></returns>
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly ILoggerFactory _loggerFactory;
        public HomeController(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }


        public IActionResult Index()
        {
            var _logger= _loggerFactory.CreateLogger("HomeClass");

            _logger.LogInformation("INDEX SAYFASINA GİRİLDİ");
            _logger.LogCritical("INDEX SAYFASINA GİRİLDİ");
            _logger.LogDebug("INDEX SAYFASINA GİRİLDİ");
            _logger.LogError("INDEX SAYFASINA GİRİLDİ");
            _logger.LogTrace("INDEX SAYFASINA GİRİLDİ");
            _logger.LogWarning("INDEX SAYFASINA GİRİLDİ");
            return View();
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