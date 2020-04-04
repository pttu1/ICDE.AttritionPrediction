using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace ICDE.CompareProducts.Models
{
    public class EmployeeViewModel
    {
        public List<Employee> Employees { get; set; }
        public SelectList JobRoles { get; set; }
        public string EmployeeType { get; set; }
        public string SearchString { get; set; }
    }
}
