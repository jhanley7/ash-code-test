using Ash.Employees.Api.Dtos;
using Ash.Employees.Database.Models;
using AutoMapper;

namespace Ash.Employees.Api;

public class Mapping : Profile
{
    public Mapping()
    {
        CreateMap<Employee, EmployeeDto>();
        CreateMap<CreateEmployeeDto, Employee>();
    }
}
