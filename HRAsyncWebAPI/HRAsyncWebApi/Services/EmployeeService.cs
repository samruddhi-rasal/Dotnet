using HRAsyncWebApi.Models;
using HRAsyncWebApi.Repositories;

namespace HRAsyncWebApi.Services
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public Task<List<Employee>> GetEmployeesAsync()
            => _repository.GetAllAsync();

        public Task<Employee?> GetEmployeeAsync(int id)
            => _repository.GetByIdAsync(id);

        public Task AddEmployeeAsync(Employee employee)
            => _repository.AddAsync(employee);
    }
}