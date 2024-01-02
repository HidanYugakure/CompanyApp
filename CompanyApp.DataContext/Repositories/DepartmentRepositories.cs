using CompanyApp.DataContext.Interface;
using CompanyApp.Domain.Models;

namespace CompanyApp.DataContext.Repositories
{
    public class DepartmentRepositories : IRepositories <Department>
    {

        public bool Create(Department entity)
        {
            try
            {
                DbContext.Departments.Add(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Department entity)
        {
            try
            {
                DbContext.Departments.Remove(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Department Get(Predicate<Department> filter)
        {
            return DbContext.Departments.Find(filter);
        }
        public List<Department> GetAll(Predicate<Department> filter = null)
        {
            return filter is null ? DbContext.Departments : DbContext.Departments.FindAll(filter);
        }
        public bool Update(Department entity)
        {
            try
            {
                var existDepartment = Get(s => s.Id == entity.Id);
                existDepartment = entity;
                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

