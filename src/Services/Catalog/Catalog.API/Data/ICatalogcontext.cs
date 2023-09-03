using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public interface ICatalogcontext
    {
        IMongoCollection<Product> Products { get; }
    }
}
