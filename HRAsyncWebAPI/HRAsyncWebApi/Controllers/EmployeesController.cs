using HRAsyncWebApi.Models;
using HRAsyncWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace HRAsyncWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeService _service;

        public EmployeesController(EmployeeService service)
        {
            _service = service;
        }

        // GET: api/employees
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var employees = await _service.GetEmployeesAsync();
            return Ok(employees);
        }

        // GET: api/employees/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var employee = await _service.GetEmployeeAsync(id);
            if (employee == null)
                return NotFound();

            return Ok(employee);
        }

        // POST: api/employees
        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            await _service.AddEmployeeAsync(employee);
            return CreatedAtAction(nameof(GetById),
                new { id = employee.Id }, employee);
        }
    }
}