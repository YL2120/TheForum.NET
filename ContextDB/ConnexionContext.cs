

namespace ContextDB
{
    public class ConnexionContext
    {
        private readonly TheForumContext context;
        

        public ConnexionContext(TheForumContext context)
        {
            this.context = context;
       
        }


    }
}