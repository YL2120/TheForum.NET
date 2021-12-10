using TheForum.Data;
using TheForum.Data.DataLayers;

namespace DBConnection
{
    public class ForumConnection
    {
        private readonly TheForumContext context;
        private BoardDataLayer boarddatalayer;
        private TopicDataLayer topicdatalayer;

        public ForumConnection(TheForumContext context, BoardDataLayer boarddatalayer, TopicDataLayer topicdatalayer)
        {
            this.context = context;
            this.boarddatalayer = boarddatalayer;
            this.topicdatalayer = topicdatalayer;
        }
    }
}