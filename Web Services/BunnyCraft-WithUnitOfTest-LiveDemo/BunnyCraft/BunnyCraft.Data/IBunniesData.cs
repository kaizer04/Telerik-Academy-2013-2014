using BunnyCraft.Data.Repositories;
using BunnyCraft.Models;
namespace BunnyCraft.Data
{
    public interface IBunniesData
    {
        IRepository<Bunny> Bunnies { get; }

        IRepository<AirCraft> AirCrafts { get; }
        
        void SaveChanges();
    }
}
