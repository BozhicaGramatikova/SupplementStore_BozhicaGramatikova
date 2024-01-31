using SupplementStoreModels.Models;

namespace SupplementStoreBL.Interfaces
{
    public interface IStoreService
    {
        List<Store> GetAll();

        Store? GetById(int id);

        void Add(Store store);

        void Delete(int id);
    }
}
