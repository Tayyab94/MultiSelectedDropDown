using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace singleOrMultipleDropdown.Models
{
    public class SelectedEmployees
    {
        public int Id { get; set; }
        public string SelectedEmployeeID { get; set; }


        [NotMapped]
        public IEnumerable<Employee> EmployeeCollection { get; set; }

        public string [] SelectedEmployeeArray { get; set; }
    }
}