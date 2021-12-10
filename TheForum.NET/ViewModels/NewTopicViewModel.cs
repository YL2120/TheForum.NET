using TheForum.Data.Models;

namespace TheForum.NET.ViewModels
{
    public class NewTopicViewModel
    {
        public List<Board> Boards { get; set; }
        public Topic NewTopic { get; set; }

        public string Board_Name { get; set; }

    }
}
