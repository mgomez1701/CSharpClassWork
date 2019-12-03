﻿using System;
using System.Collections.Generic;

namespace MakingAPIs.Models
{
    public partial class Employees
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}
