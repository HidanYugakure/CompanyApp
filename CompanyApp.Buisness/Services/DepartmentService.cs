using CompanyApp.Buisness.Interface;
using CompanyApp.DataContext.Repositories;
using CompanyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApp.Buisness.Services
{
    public class DepartmentService : IDepartament
    {
        private readonly DepartmentRepositories _departmentRepositories=new();
        private readonly EmployeeRepositories _employeeRepositories = new();
        private int Count = 1;
        public Department Create(Department department)
        {
         Department existDepartmentWithName = _departmentRepositories.Get(d=>d.Name.Equals(department.Name,StringComparison.OrdinalIgnoreCase));
         if (existDepartmentWithName is not null) return null;
         department.Id = Count;
            if (_departmentRepositories.Create(department))
            {
                Count++;
                return department;
            }
            return null;
        }
        public Department Delete(int id)
        {
            Department existdepartment = _departmentRepositories.Get(e => e.Id == id);
            if (existdepartment is not null) return null;
            if (_departmentRepositories.Delete(existdepartment)) return existdepartment;
            return null;
        }

        public Department Get(int id)
        {
            Department existDepartment = _departmentRepositories.Get(d => d.Id == id);
            if (existDepartment is null) return null;
            return existDepartment;
        }

        public List<Department> GetAll(string name)
        {
          return _departmentRepositories.GetAll(d => d.Name == name);
        }

        public List<Department> GetAll(int capacity)
        {
            return _departmentRepositories.GetAll(d => d.Capacity == capacity);
        }

        public List<Department> GetAll()
        {
            return _departmentRepositories.GetAll();
        }
        public Department Update(int id, Department department)
        {
            var existDepartment = _departmentRepositories.Get(d => d.Id == id);
            if (existDepartment is null) return null;
            var existDepartmentWithName = _departmentRepositories.Get(g => g.Name.Equals(department.Name, StringComparison.OrdinalIgnoreCase) && g.Id != existDepartment.Id);
            if (existDepartmentWithName is not null) return null;
            existDepartment.Name = department.Name;
            var result = _departmentRepositories.Update(department);
            if (result)
            {
                return existDepartment;
            }
            return null;
        }
    }
}
