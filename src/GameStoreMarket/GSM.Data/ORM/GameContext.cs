using GSM.Core.Domain.Games;
using GSM.Core.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace GSM.Data.ORM
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {
            
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<GameCategory> GameCategories { get; set; }
        public  DbSet<User> Users { get; set; }


    }
}
