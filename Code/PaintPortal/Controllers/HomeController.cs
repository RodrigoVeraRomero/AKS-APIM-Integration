using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PaintPortal.APIS;
using PaintPortal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PaintPortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IApiCalls _apiCalls;

        public HomeController(ILogger<HomeController> logger, IApiCalls apiCalls)
        {
            _logger = logger;
            _apiCalls = apiCalls;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _apiCalls.GetPeopleAsync();
            return View(data);
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
