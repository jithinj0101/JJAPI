using JJ_Code.API.Models.Domain;

namespace JJ_Code.API.Repositories
{
    public interface IRegionRepository
    {
        //create a contract
        Task<IEnumerable<Region>> GetAllAsync();
    }
}
