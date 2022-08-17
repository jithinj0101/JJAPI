using JJ_Code.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace JJ_Code.API.Data
{
    public class JJDbContext:DbContext
    {
        //Create a constuctor and pass dbcontext options of type class and pass it to the base class
        public JJDbContext(DbContextOptions<JJDbContext> options):base(options)
        {

        }

        //Create Properties 
        //Telling EF to create tables if it doesnt exist in the Db.
        //Enables EF to use the DbContext to process and query the created tables.
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
