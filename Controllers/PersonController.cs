using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using PersonManagement.Models;

namespace PersonManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        [HttpGet]
        [Authorize(Roles = "Admin, Standard")]
        public IActionResult Index()
        {
            var persons = _personRepository.person;
            return Ok(persons);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin, Standard")]
        public IActionResult Details(int id)
        {
            if (id == 0 || _personRepository.GetPersonById(id) == null)
            {
                return NotFound();

            }

            var person = _personRepository.GetPersonById(id);

            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        [HttpPost]
        [Authorize(Roles = "Admin, Standard")]
        public IActionResult Create(Pm01Person person)
        {
            if (ModelState.IsValid)
            {
                _personRepository.AddPerson(person);
            }
            return Ok(person);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id, Pm01Person person)
        {

            if (ModelState.IsValid)
            {

                if (id != person.IdPerson)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _personRepository.UpdatePerson(id, person);
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!PersonExists(person.IdPerson))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
            }
            return Ok(person);

        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            if (_personRepository.person == null)
            {
                return Problem("Entity set '_personRepository.person'  is null.");
            }
            var person = _personRepository.GetPersonById(id);
            if (person != null)
            {
                _personRepository.DeletePerson(person);
            }

            return Ok();
        }

        private bool PersonExists(int id)
        {
            return _personRepository.person.Any(i => i.IdPerson == id);
        }
    }
}
