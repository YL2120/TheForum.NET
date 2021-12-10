using TheForum.Data.Models;

namespace TheForum.Data.DataLayers
{
    public class TopicDataLayer
    {
        private TheForumContext context;

        public TopicDataLayer(TheForumContext context)
        {
            this.context = context;
        }

        public void CreateTopic(Topic topic, string username,DateTime submit_date,string board_name)
        {
            var board = this.context.Boards
                    .Where(b => b.Name == board_name)
                    .FirstOrDefault();

            Topic topic1 = new Topic()
            {
                Title = topic.Title,
                Content = topic.Content,
                Creation_Date = submit_date,
                BoardID = board.Id,
                UserName = username
            };

            this.context.Topics.Add(topic1);
            this.context.SaveChanges();
        }


    }
}
