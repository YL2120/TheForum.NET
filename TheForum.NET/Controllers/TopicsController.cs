using Microsoft.AspNetCore.Mvc;
using TheForum.Data;

namespace TheForum.NET.Controllers
{
    public class TopicsController : Controller
    {
        private readonly TheForumContext context;

        public TopicsController(TheForumContext context)
        {
            this.context = context;
        }

        
        public IActionResult Index()
        {
            return View();
        }
    }
}
