using WalksAPI.Models.Domain;

namespace WalksAPI.Repository
{
    public interface IRegionRepository
    {
        IEnumerable<Region> GetAll();
    }
}
