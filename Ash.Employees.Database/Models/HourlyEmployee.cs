using System;
using System.Collections.Generic;

namespace Ash.Employees.Database.Models
{
    public partial class HourlyEmployee
    {
        public int Id { get; set; }
        public decimal PayPerHour { get; set; }

        public virtual Employee IdNavigation { get; set; } = null!;
    }
}
