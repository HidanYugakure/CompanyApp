using CompanyApp.Domain.Models;

namespace CompanyApp.Buisness.Interface
{
    public interface IEmployee
    {
        List<Employee> GetAll();
        List<Employee> GetEmployeeDepartmentId(string departmentName);
        List<Employee> GetAll(string name);
        List<Employee> GetAll(int age);
        List<Employee> GetAll(byte departmentId);

        Employee Create(Employee employee, string departmentName);
        Employee Get(int id);
        Employee Update (int id, Employee employee, string departmentName);
        Employee Delete (int id);
    }
}
