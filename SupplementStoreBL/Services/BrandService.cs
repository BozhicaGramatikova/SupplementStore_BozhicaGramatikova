using SupplementStoreBL.Interfaces;
using SupplementStoreModels.Models.Requests;
using SupplementStoreModels.Models.Responses;

namespace SupplementStoreBL.Services;

public class BrandService : IBrandService
{
    private readonly ISupplementService _supplementService;
    private readonly IStoreService _storeService;
    public BrandService(IStoreService storeService, ISupplementService supplementService)
    {
        _storeService = storeService;
        _supplementService = supplementService;
    }

    public int CheckStoreCount(int input)
    {
        var supplements = _supplementService.GetAll();
        return supplements.Count + input;
    }

    public GetAllSupplementsByStoreResponse GetAllSupplementsByStoreAfterDate(GetAllSupplementsByStoreRequest request)
    {
        var result = new GetAllSupplementsByStoreResponse();
        result.Store = _storeService.GetById(request.StoreId);
        result.Supplements = _supplementService.GetAllByStoreId(request.StoreId);
        return result;
    }

}