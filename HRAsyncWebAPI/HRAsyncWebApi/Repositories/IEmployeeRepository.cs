using HRAsyncWebApi.Models;

namespace HRAsyncWebApi.Repositories
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllAsync();
        Task<Employee?> GetByIdAsync(int id);
        Task AddAsync(Employee employee);
    }
}