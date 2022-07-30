using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses.Models.Employees
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? DoB { get; set; }
        public Department? Department { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}
