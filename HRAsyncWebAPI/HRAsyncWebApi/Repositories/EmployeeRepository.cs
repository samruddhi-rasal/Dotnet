using HRAsyncWebApi.Models;

namespace HRAsyncWebApi.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private static readonly List<Employee> _employees = new()
        {
            new Employee { Id=101, Name="Amit", Department="IT", Salary=50000 },
            new Employee { Id=102, Name="Neha", Department="HR", Salary=40000 }
        };

        public async Task<List<Employee>> GetAllAsync()
        {
            await Task.Delay(1000); // simulate DB latency
            return _employees;
        }

        public async Task<Employee?> GetByIdAsync(int id)
        {
            await Task.Delay(500);
            return _employees.FirstOrDefault(e => e.Id == id);
        }

        public async Task AddAsync(Employee employee)
        {
            await Task.Delay(500);
            _employees.Add(employee);
        }
    }
}