using Microsoft.AspNetCore.Mvc;
using PersonManagement.Models;

namespace PersonManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MaritalStatusController : ControllerBase
    {

        private readonly IMaritalStatusRepository _maritalStatusesRepository;

        public MaritalStatusController(IMaritalStatusRepository maritalStatusesRepository)
        {
            _maritalStatusesRepository = maritalStatusesRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var maritalStatuses = _maritalStatusesRepository.maritalStatuses;
            return Ok(maritalStatuses);
        }

        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            if (id == 0 || _maritalStatusesRepository.GetMaritalStatusById(id) == null)
            {
                return NotFound();

            }

            var person = _maritalStatusesRepository.GetMaritalStatusById(id);

            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }
    }
}
