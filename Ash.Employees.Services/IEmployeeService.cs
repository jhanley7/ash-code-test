using Ash.Employees.Database.Models;

namespace Ash.Employees.Services
{
    public interface IEmployeeService
    {
        /// <summary>
        /// Gets all employees
        /// </summary>
        /// <returns>A list of all employees</returns>
        Task<IEnumerable<Employee>> GetAllAsync();
        /// <summary>
        /// Creates a new employee
        /// </summary>
        /// <param name="employee">The employee being created</param>
        /// <returns>The new employee from the database</returns>
        Task<Employee> CreateEmployee(Employee employee);
    }
}
