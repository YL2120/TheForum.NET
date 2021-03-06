using TheForum.Data.Models;

namespace TheForum.Data.DataLayers
{
    public class TopicDataLayer
    {
        private readonly TheForumContext context;


        public TopicDataLayer(TheForumContext context)
        {
            this.context = context;
        }

        public List<Topic> DisplayAll(int id)
        {
            var query = this.context.Topics
                        .Where(t => t.BoardID == id);
    
                        

            return query.ToList();
        }

        public int CreateTopic(Topic topic, string username,DateTime submit_date,string board_name)
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

            return board.Id;
        }


    }
}
