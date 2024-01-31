using SupplementStoreBL.Interfaces;
using SupplementStoreDL.Interfaces;
using SupplementStoreModels.Models;

namespace SupplementStoreBL.Services
{
    public class StoreService : IStoreService
    {
        private readonly IStoreRepository _storeRepository;

        public StoreService(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        public void Add(Store store)
        {
            _storeRepository.Add(store);
        }

        public void Delete(int id)
        {
            _storeRepository.Delete(id);
        }

        public List<Store> GetAll()
        {
            return _storeRepository.GetAll();  
        }

        public Store? GetById(int id)
        {
            return _storeRepository.GetById(id);
        }
    }
}
