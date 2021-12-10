using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TheForum.Data;
using TheForum.Data.DataLayers;
using TheForum.Data.Models;
using TheForum.NET.ViewModels;

namespace TheForum.NET.Controllers
{
    public class TopicsController : Controller
    {
        
        private readonly UserManager<ForumUser> _userManager;
        private BoardDataLayer boarddatalayer;
        private TopicDataLayer topicdatalayer;
        

        public TopicsController(UserManager<ForumUser> userManager,BoardDataLayer boarddatalayer,
        TopicDataLayer topicdatalayer)
        {
            this._userManager = userManager;
            this.boarddatalayer = boarddatalayer;
            this.topicdatalayer = topicdatalayer;
            
        }

        [Route("Topics/Board/{id}")]
        public IActionResult Index(int id)
        {

            List<Topic> result = this.topicdatalayer.DisplayAll(id);
            ViewData["id"] = id;
            return View(result);
        }

        //CREATIONS OF TOPIC
        //Form
        
        [Authorize]
        [Route("Topics/Board/AddTopic/{id}")]
        public ActionResult AddTopic(int id)
        {
            var TopicViewModel = new NewTopicViewModel
            {
                Boards = this.boarddatalayer.DisplayAll(),
                NewTopic = new Topic()
            };
            ViewData["id"] = id; // id of the board for the route
            return View(TopicViewModel);
        }

        //Send to the DB

        [HttpPost]
        [Route("Topics/Board/AddTopic/{id}")]
        public ActionResult AddTopic(NewTopicViewModel topic)
        {

            //topic.Boards = this.boarddatalayer.DisplayAll();    
            //ActionResult result = this.View(topic);
            

            
            var username = this._userManager.GetUserName(User); //get username currently logged in
            DateTime submit_date = DateTime.Now;
            int board_id = this.topicdatalayer.CreateTopic(topic.NewTopic, username, submit_date,topic.Board_Name );
            
             ActionResult result = this.RedirectToAction(actionName: "Index", controllerName: "Topics", new { id = board_id});
            

            return result;
        }

    }
}
