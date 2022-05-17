using System;
using System.Collections.Generic;

namespace Ash.Employees.Database.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Address1 { get; set; } = null!;

        public virtual HourlyEmployee HourlyEmployee { get; set; } = null!;
        public virtual Supervisor Supervisor { get; set; } = null!;
    }
}
