using SupplementStoreModels.Models.Requests;
using SupplementStoreModels.Models.Responses;

namespace SupplementStoreBL.Interfaces
{
    public interface IBrandService
    {
        public GetAllSupplementsByStoreResponse GetAllSupplementsByStoreAfterDate(GetAllSupplementsByStoreRequest request);
        public int CheckStoreCount(int input);
    }
}

