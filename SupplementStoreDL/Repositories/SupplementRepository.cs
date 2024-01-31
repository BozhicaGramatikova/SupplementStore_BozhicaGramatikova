using SupplementStoreDL.Interfaces;
using SupplementStoreDL.MemoryDB;
using SupplementStoreModels.Models;

namespace SupplementStoreDL.Repositories
{
    public class SupplementRepository : ISupplementRepository
    {
        public void Add(Supplement supplement)
        {
            InMemoryDb.Supplements.Add(supplement);
        }

        public void Delete(int id)
        {
            var supplement = GetById(id);
            if (supplement != null) 
            {
                InMemoryDb.Supplements.Remove(supplement);
            }
        }

        public List<Supplement> GetAll()
        {
            return InMemoryDb.Supplements;
        }

        public List<Supplement> GetAllByStoreId(int storeId)
        {
            return InMemoryDb.Supplements.Where(b => b.StoreId == storeId).ToList();
        }

        public Supplement? GetById(int id)
        {
            return InMemoryDb.Supplements.FirstOrDefault(b => b.Id == id);
        }
    }
}
