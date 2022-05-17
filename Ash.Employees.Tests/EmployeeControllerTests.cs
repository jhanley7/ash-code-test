using Ash.Employees.Api;
using Ash.Employees.Database.Models;
using Ash.Employees.Services;
using Ash.Employees.Services.Controllers;
using AutoMapper;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Ash.Employees.Tests
{
    public class EmployeeControllerTests
    {
        [Fact]
        public async Task Get_returns_all_employees_from_service_with_200()
        {
            // Arrange
            var employeeService = A.Fake<IEmployeeService>();

            var mapping = new Mapping();
            var mapperCfg = new MapperConfiguration(cfg => cfg.AddProfile(mapping));
            var mapper = new Mapper(mapperCfg);

            var suj = new EmployeeController(employeeService, mapper, new NullLogger<EmployeeController>());

            A.CallTo(() => employeeService.GetAllAsync()).Returns(new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    FirstName = "Test",
                    LastName = "User",
                    Address1 = "1234 Main St."
                },
                new Employee
                {
                    Id = 2,
                    FirstName = "Demo",
                    LastName = "User",
                    Address1 = "4321 Main St."
                }
            });

            // Act
            var result = await suj.Get();

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
}