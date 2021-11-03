using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExamApiSBA.DataLayer;
using ExamApiSBA.Models;


namespace ExamApiSBA.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        static readonly IDepartmentRepository departmentrepository = new DepartmentRepository();//giving referance of repository.
        private int _deptid = 1;
        EmployeeDepartmentDataLayer deptDal;
        public DepartmentRepository()
        {
            deptDal = new EmployeeDepartmentDataLayer();
        }
        public IEnumerable<Department> GetAllDepartment()
        {
            return deptDal.departments.ToList();
        }

        public Department AddDepartment(Department department)
        {
            if (department == null)
            {
                throw new ArgumentNullException("Department");
            }
            department.Dept_Id = _deptid++;

            deptDal.departments.Add(department);
            deptDal.SaveChanges();
            return department;
        }
    }
}