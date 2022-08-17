using JJ_Code.API.Data;
using JJ_Code.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace JJ_Code.API.Repositories
{
    //Create Interface
    public class RegionRepository : IRegionRepository
    {
        private readonly JJDbContext jJDbContext;

        //Create a constructor and inject the DbContext
        public RegionRepository(JJDbContext jJDbContext)
        {
            this.jJDbContext = jJDbContext;
        }

        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await jJDbContext.Regions.ToListAsync();
        }
    }
}
