using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityCrudOperation.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }

        public virtual Department Department { get; set; }
    }
}