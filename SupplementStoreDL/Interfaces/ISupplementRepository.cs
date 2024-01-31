using SupplementStoreModels.Models;

namespace SupplementStoreDL.Interfaces
{
    public interface ISupplementRepository
    {
        List<Supplement> GetAll();

        List<Supplement> GetAllByStoreId(int storeId);

        Supplement? GetById(int id);

        void Add(Supplement supplement);

        void Delete(int id);
    }
}
