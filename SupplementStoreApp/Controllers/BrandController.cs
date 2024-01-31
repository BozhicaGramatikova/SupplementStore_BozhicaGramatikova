using Microsoft.AspNetCore.Mvc;
using SupplementStoreBL.Interfaces;
using SupplementStoreModels.Models.Requests;
using SupplementStoreModels.Models.Responses;

namespace SupplementStoreApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrandController : ControllerBase
    {
        public readonly IBrandService _BrandService;

        public BrandController(IBrandService brandService)
        {
            _BrandService = brandService;
        }


        [HttpPost("GetAllSupplementsByStoreId")]
        public GetAllSupplementsByStoreResponse GetAllSupplementsByStoreAfterDate(GetAllSupplementsByStoreRequest request)
        {
            return _BrandService.GetAllSupplementsByStoreAfterDate(request);
        }
    }
}