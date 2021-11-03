using ExamApiSBA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamApiSBA.Repository
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartment();
        Department AddDepartment(Department department);
    }
}