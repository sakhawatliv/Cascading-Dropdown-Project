using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace CascadingDropdownProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}