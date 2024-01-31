using SupplementStoreDL.Interfaces;
using SupplementStoreDL.MemoryDB;
using SupplementStoreModels.Models;

namespace SupplementStoreDL.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        public void Add(Store store)
        {
            InMemoryDb.Stores.Add(store);
        }

        public void Delete(int id)
        {
            var store = GetById(id);
            if (store != null)
            {
                InMemoryDb.Stores.Remove(store);
            }
        }

        public List<Store> GetAll()
        {
            return InMemoryDb.Stores;
        }

        public Store? GetById(int id)
        {
            return InMemoryDb.Stores.FirstOrDefault(a => a.Id == id);
        }
    }
}
