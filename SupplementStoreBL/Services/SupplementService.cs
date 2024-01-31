using SupplementStoreBL.Interfaces;
using SupplementStoreDL.Interfaces;
using SupplementStoreModels.Models;

namespace SupplementStoreBL.Services
{
    public class SupplementService : ISupplementService
    {
       
        private readonly ISupplementRepository _supplementRepository;

        public SupplementService(ISupplementRepository supplementRepository)
        {
            _supplementRepository = supplementRepository;
        }

        public void Add(Supplement supplement)
        {
            _supplementRepository.Add(supplement);
        }

        public void Delete(int id)
        {
            _supplementRepository.Delete(id);
        }

   
        public List<Supplement> GetAll()
        {
            return _supplementRepository.GetAll();
        }

        public List<Supplement> GetAllByStoreId(int storeId)
        {
            return _supplementRepository.GetAllByStoreId(storeId);
        }

        public Supplement? GetById(int id)
        {
            return _supplementRepository.GetById(id);
        }
    }
}

