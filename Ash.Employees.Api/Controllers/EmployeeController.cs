using Ash.Employees.Api.Dtos;
using Ash.Employees.Database.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Ash.Employees.Services.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;
    private readonly IMapper _mapper;
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(IEmployeeService employeeService, IMapper mapper, ILogger<EmployeeController> logger)
    {
        _employeeService = employeeService;
        _mapper = mapper;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            var employees = await _employeeService.GetAllAsync();

            var employeeDtos = _mapper.Map<IEnumerable<EmployeeDto>>(employees);
            return Ok(employeeDtos);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error while retrieving employees");
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateEmployeeDto employeeDto)
    {
        try
        {
            var employee = _mapper.Map<Employee>(employeeDto);

            employee = await _employeeService.CreateEmployee(employee);

            return Ok(_mapper.Map<EmployeeDto>(employee));
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error while creating a new employee");
            return BadRequest();
        }
    }
}