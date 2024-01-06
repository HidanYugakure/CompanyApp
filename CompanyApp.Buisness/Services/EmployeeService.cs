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
    public class EmployeeService : IEmployee
    {
        private readonly EmployeeRepositories _employeeRepositories = new();
        private readonly DepartmentRepositories _departmentRepositories = new();
        private int Count=1;
        public Employee Create(Employee employee, string departmentName)
        {
            Department ExistDepartment = _departmentRepositories.Get(d => d.Name.Equals(departmentName, StringComparison.OrdinalIgnoreCase));
            if (ExistDepartment is null) return null;
            employee.Id = Count;
            bool result = _employeeRepositories.Create(employee);
            if (!result) return null;
            Count++;
            return employee;  
        }
        public Employee Delete(int id)
        {
            Employee existemployee=_employeeRepositories.Get(e=>e.Id == id);
            if (existemployee is not null) return null;
            if (_employeeRepositories.Delete(existemployee)) return existemployee;
            return null;
        }
        public Employee Get(int id)
        { 
            Employee existEmployee = _employeeRepositories.Get(e => e.Id == id);
            if (existEmployee is null) return null;
            return existEmployee;
        }
        public List<Employee> GetAll()
        {
            return _employeeRepositories.GetAll();
        }
        public List<Employee> GetAll(string name)
        {
            return _employeeRepositories.GetAll(e=>e.Name == name);
        }
        public List<Employee> GetAll(int age)
        {
            return _employeeRepositories.GetAll(e => e.Age==age);
        }
        public List<Employee> GetAll(byte departmentId)
        {
            return _employeeRepositories.GetAll(e => e.Equals(departmentId));
        }
        public List<Employee> GetEmployeeDepartmentId(string departmentName)
        {
            throw new NotImplementedException();
        }
        public Employee Update(int id, Employee employee, string departmentName)
        {
           Employee existEmployee = _employeeRepositories.Get(e=>e.Id == id);
            if (existEmployee is null) return null;
    
            if (!string.IsNullOrEmpty(employee.Name))
            {
                existEmployee.Name = employee.Name;
            }
            if (!string.IsNullOrEmpty(employee.LastName))
            {
                existEmployee.LastName = employee.LastName;
            }
            existEmployee.Departament = employee.Departament;
            if (_employeeRepositories.Update(existEmployee))
            {
                return existEmployee;
            }
            else
            {
                return null;
            }
        }
    }
}
