using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using ExamApiSBA.Models;
using ExamApiSBA.Repository;

namespace ExamApiSBA.Controllers
{
    public class ExamController : ApiController
    {
        static readonly IEmployeeRepository employeerepository = new EmployeeRepository();


        public IEnumerable<Employee> GetAllEmployees()
        {
            return employeerepository.GetAll();
        }

        public Employee PostEmployee(Employee employee)
        {
            employee = employeerepository.AddEmployee(employee);
            return employee;
        }

        [System.Web.Http.Route("api/Exam/GetEmployeesByDepartmentName/{deptname}")]
        public IEnumerable<Employee> GetEmployeesByDepartmentName(string deptname)
        {
            return employeerepository.EmployeesByDepartmentName(deptname);
        }

        [System.Web.Http.Route("api/Exam/GetEmployeesBySalary/{salary}")]
        public IEnumerable<Employee> GetEmployeesBySalary(int salary)
        {
            return employeerepository.EmployeesBySalary(salary);
        }



        //DEPARTMENTS
        static readonly IDepartmentRepository departmentrepository = new DepartmentRepository();
        
        public IEnumerable<Department> GetAllDepartments()
        {
            return departmentrepository.GetAllDepartment();
        }

        public Department PostDepartment(Department department)
        {
            department = departmentrepository.AddDepartment(department);
            return department;
        }



    }
}