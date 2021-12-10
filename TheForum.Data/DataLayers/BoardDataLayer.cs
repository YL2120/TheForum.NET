using TheForum.Data.Models;

namespace TheForum.Data.DataLayers
{
    public class BoardDataLayer
    {
        private readonly TheForumContext context;

        public BoardDataLayer (TheForumContext context)
        {
            this.context = context; 
        }

        public List<Board> DisplayAll()
        {
            var query = from item in this.context.Boards
                        select item;
            
            return query.ToList(); 
        }
    }
}
