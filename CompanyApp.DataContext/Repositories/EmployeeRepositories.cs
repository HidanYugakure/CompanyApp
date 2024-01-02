using CompanyApp.DataContext.Interface;
using CompanyApp.Domain.Models;

namespace CompanyApp.DataContext.Repositories
{
    public class EmployeeRepositories : IRepositories<Employee>
    {

        public bool Create (Employee entity)
        {
            try
            {
                DbContext.Employees.Add(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Employee entity)
        {
            try
            {
                DbContext.Employees.Remove(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Employee Get (Predicate<Employee> filter)
        {
            return DbContext.Employees.Find(filter);
        }
        public List<Employee> GetAll(Predicate<Employee> filter=null)
        {
            return filter is null ? DbContext.Employees : DbContext.Employees.FindAll(filter);
        }
        public bool Update(Employee entity)
        {
            try
            {
                var existEmployee = Get(s => s.Id == entity.Id);
                existEmployee = entity;
                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
