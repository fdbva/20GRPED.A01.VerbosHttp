using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _20GRPED.A01.VerbosHttp.Models;

namespace _20GRPED.A01.VerbosHttp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string OnFormGet(
            string arg)
        {
            return $"OnGet result = {arg}";
        }

        [HttpPost]
        public string OnFormPost(
            string arg)
        {
            return $"OnPost result = {arg}";
        }

        [HttpGet("Home/OnFetch")]
        public string OnFetchGet(
            string arg)
        {
            return $"OnGet result = {arg}";
        }

        [HttpPost("Home/OnFetch")]
        public string OnFetchPost(
            string arg)
        {
            return $"OnPost result = {arg}";
        }

        [HttpPut("Home/OnFetch")]
        public string OnFetchPut(
            string arg)
        {
            return $"OnPut result = {arg}";
        }

        [HttpDelete("Home/OnFetch")]
        public string OnFetchDelete(
            string arg)
        {
            return $"OnDelete result = {arg}";
        }

        public IActionResult Index()
        {
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
