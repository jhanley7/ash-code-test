using Ash.Employees.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Ash.Employees.Services;

public class EmployeeService : IEmployeeService
{
    private readonly EmployeesContext _db;
    private readonly ILogger<EmployeeService> _logger;

    public EmployeeService(EmployeesContext db, ILogger<EmployeeService> logger)
    {
        _db = db;
        _logger = logger;
    }

    public async Task<Employee> CreateEmployee(Employee employee)
    {
        await _db.Employees.AddAsync(employee);
        await _db.SaveChangesAsync();

        return employee;
    }

    public async Task<IEnumerable<Employee>> GetAllAsync()
    {
        return await _db.Employees.ToListAsync();
    }
}