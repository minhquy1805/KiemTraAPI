using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Models;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IGenericRepository<Department> _departmentRepository;

        public DepartmentController(IGenericRepository<Department> departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddPerson(Department department)
        {
            await _departmentRepository.AddAsync(department);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepartments()
        {
            var departments = await _departmentRepository.GetAllAsync();
            return Ok(departments);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartmentById(int id)
        {
            var department = await _departmentRepository.GetByIdAsync(id);
            if (department == null)
            {
                return NotFound(); // Trả về mã lỗi 404 nếu không tìm thấy phòng ban
            }
            return Ok(department); 
        }

    }
}
