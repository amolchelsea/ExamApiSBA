using ExamApiSBA.DataLayer;
using ExamApiSBA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamApiSBA.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        static readonly IEmployeeRepository employeerepository = new EmployeeRepository();//giving referance of repository.
        private int _Empid = 1;
        EmployeeDepartmentDataLayer empDal;
        public EmployeeRepository()
        {
            empDal = new EmployeeDepartmentDataLayer();
        }
        public IEnumerable<Employee> GetAll()
        {
            return empDal.employees.ToList();
        }
        public Employee AddEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("Employee");
            }
            employee.Id = _Empid++;

            empDal.employees.Add(employee);
            empDal.SaveChanges();
            return employee;
        }
        public IEnumerable<Employee> EmployeesByDepartmentName(string deptname)
        {
            return empDal.employees.Where(x => x.departments.Dept_Name == deptname).ToList();
        }
        public IEnumerable<Employee> EmployeesBySalary(int salary)
        {
            return empDal.employees.Where(s => s.Salary == salary).ToList();
        }


    }
}