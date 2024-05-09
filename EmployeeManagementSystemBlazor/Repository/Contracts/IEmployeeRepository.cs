﻿using EmployeeManagementSystemBlazor.Models;

namespace EmployeeManagementSystemBlazor.Repository.Contracts
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int id);
        Task AddEmployee(Employee employee);
        Task UpdateEmployee(Employee employee);
        Task DeleteEmployee(int id);
    }
}
