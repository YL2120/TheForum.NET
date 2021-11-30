using Microsoft.EntityFrameworkCore;
using TheForum.Data.Models;

namespace TheForum.Data
{
    public class TheForumContext : DbContext
    {



        public TheForumContext(DbContextOptions<TheForumContext> options) : base(options)
        {
        }

        protected TheForumContext()
        {
        }

        public DbSet<Board> Boards { get; set; }

    }
}

