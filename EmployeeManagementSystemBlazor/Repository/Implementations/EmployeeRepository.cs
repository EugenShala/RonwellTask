using EmployeeManagementSystemBlazor.DataAccess;
using EmployeeManagementSystemBlazor.Models;
using EmployeeManagementSystemBlazor.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem_Blazor.Repository.Implementations
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _dbContext;

        public EmployeeRepository(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddEmployee(Employee employee)
        {
           _dbContext.Employees.Add(employee);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteEmployee(int id)
        {
            var employee = await _dbContext.Employees.FindAsync(id);
            _dbContext.Employees.Remove(employee);
            await _dbContext.SaveChangesAsync();    
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            return await _dbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _dbContext.Employees.FindAsync(id);
        }

        public async Task UpdateEmployee(Employee employee)
        {
            _dbContext.Entry(employee).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
