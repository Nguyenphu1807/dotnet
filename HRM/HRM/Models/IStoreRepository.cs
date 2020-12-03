using System.Linq;

namespace HRM.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
