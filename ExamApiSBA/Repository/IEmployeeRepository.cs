using ExamApiSBA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamApiSBA.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee AddEmployee(Employee employee);
        IEnumerable<Employee> EmployeesByDepartmentName(string deptname);
        IEnumerable<Employee> EmployeesBySalary(int salary);
    }
}