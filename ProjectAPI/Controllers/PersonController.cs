using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Models;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IGenericRepository<Person> _personRepository;

        public PersonController(IGenericRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddPerson(Person person)
        {
            await _personRepository.AddAsync(person);
            return Ok();
        }
    }
}
