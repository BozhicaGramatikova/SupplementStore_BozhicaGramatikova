using SupplementStoreModels.Models;

namespace SupplementStoreBL.Interfaces
{
    public interface ISupplementService
    {
        List<Supplement>GetAll();

        List<Supplement> GetAllByStoreId(int storeId);

        Supplement? GetById(int id);

        void Add(Supplement supplement);

        void Delete(int id);
    }
}
