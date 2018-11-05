using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace singleOrMultipleDropdown.Models
{
    public class DemoContext:DbContext
    {
        public DemoContext():base("Pro")
        {

        }

       public DbSet<Employee> Employees { get; set; }

        public DbSet<SelectedEmployees> SelectedEmployees { get; set; }
    }
}