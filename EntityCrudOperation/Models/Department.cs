using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityCrudOperation.Models
{
    public class Department
    {
        public string DepartmentName { get; set; }
        public string Location { get; set; }
        public int Count { get; set; }

        public int Id { get; set; }
        public virtual List<Employee> Employee { get; set; }
    }
}