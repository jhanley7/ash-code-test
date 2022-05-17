using System;
using System.Collections.Generic;

namespace Ash.Employees.Database.Models
{
    public partial class Supervisor
    {
        public int Id { get; set; }
        public decimal AnnualSalary { get; set; }

        public virtual Employee IdNavigation { get; set; } = null!;
    }
}
