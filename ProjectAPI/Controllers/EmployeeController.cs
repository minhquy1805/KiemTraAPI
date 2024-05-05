using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Models;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IGenericRepository<Employee> _employeeRepository;

        public EmployeeController(IGenericRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddPerson(Employee employee)
        {
            await _employeeRepository.AddAsync(employee);
            return Ok();
        }
    }
}
