using Microsoft.AspNetCore.Mvc;
using SupplementStoreBL.Interfaces;
using SupplementStoreModels.Models;

namespace SupplementStoreApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SupplementController : ControllerBase
    {
        private readonly ISupplementService _supplementService;

        public SupplementController(ISupplementService supplementService)
        {
            _supplementService = supplementService;
        }

        [HttpGet("Get All")]
        public IEnumerable<Supplement> GetAll()
        {
            return _supplementService.GetAll();
        }

        [HttpPost("Add")]
        public void Add([FromBody] Supplement supplement)
        {
            _supplementService.Add(supplement);
        }

        [HttpGet("GetById")]
        public Supplement? GetById(int id)
        {
            return _supplementService.GetById(id);
        }

        [HttpDelete("Delete")]
        public void DeleteById(int id) 
        {
            _supplementService.Delete(id);
        }

    }
}