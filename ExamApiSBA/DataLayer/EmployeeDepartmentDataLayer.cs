using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExamApiSBA.Models;
using System.Data.Entity;

namespace ExamApiSBA.DataLayer
{
    public class EmployeeDepartmentDataLayer : DbContext
    {
        public DbSet<Department> departments { get; set; }
        public DbSet<Employee> employees { get; set; }
    }
}