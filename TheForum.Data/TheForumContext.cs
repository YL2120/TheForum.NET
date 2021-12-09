using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheForum.Data.Models;

namespace TheForum.Data
{
    public class TheForumContext : IdentityDbContext<ForumUser>
    {



        public TheForumContext(DbContextOptions<TheForumContext> options) : base(options)
        {
        }

        protected TheForumContext()
        {
        }

        public DbSet<Board> Boards { get; set; }
        public DbSet<Topic> Topics { get; set; }

    }
}

