using System;
using System.Collections.Generic;

namespace Ash.Employees.Database.Models
{
    public partial class Manager
    {
        public int Id { get; set; }
        public decimal MaxExpenseAmount { get; set; }

        public virtual Supervisor IdNavigation { get; set; } = null!;
    }
}
