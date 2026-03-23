using Microsoft.AspNetCore.Mvc;
using PharmacyApi.Models;
using PharmacyApi.Services;
using System.Linq;

namespace PharmacyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicineController : ControllerBase
    {
        private readonly JsonDataService _service = new JsonDataService();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        [HttpPost]
        public IActionResult Add([FromBody] Medicine medicine)
        {
            var list = _service.GetAll();
            medicine.Id = list.Count > 0 ? list.Max(x => x.Id) + 1 : 1;

            list.Add(medicine);
            _service.Save(list);

            return Ok(medicine);
        }
    }
}
