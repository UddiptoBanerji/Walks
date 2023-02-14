using WalksAPI.Data;
using WalksAPI.Models.Domain;

namespace WalksAPI.Repository
{
    public class RegionRepository : IRegionRepository
    {
        private readonly WalksDbContext walksDbContext;

        public RegionRepository(WalksDbContext walksDbContext)
        {
            this.walksDbContext = walksDbContext;
        }
        public IEnumerable<Region> GetAll()
        {
            return walksDbContext.Regions.ToList();

            //throw new NotImplementedException();

        }
    }
}
