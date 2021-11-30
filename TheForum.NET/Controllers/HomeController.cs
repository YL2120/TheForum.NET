using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheForum.Data;
using TheForum.Data.DataLayers;
using TheForum.NET.Models;

namespace TheForum.NET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly TheForumContext context;
        private BoardDataLayer boarddatalayer;

        public HomeController(ILogger<HomeController> logger, TheForumContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(this.boarddatalayer.DisplayAll());
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