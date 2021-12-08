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

        [Route("Topics/Board/{id:int}")]
        public IActionResult Index(int id)
        {
            
            return View();
        }

        public ActionResult NewTopic()
        {
            return View();
        }
    }
}
