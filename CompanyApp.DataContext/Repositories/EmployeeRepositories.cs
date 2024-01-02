using CompanyApp.DataContext.Interface;
using CompanyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApp.DataContext.Repositories
{
    public class EmployeeRepositories : IRepositories<Employee>
    {

        public bool Create (Employee entity)
        {
            try
            {
                DbContext.employee.Add(entity);
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

                DbContext.employee.Remove(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public bool Update(Employee entity)
        {
            try
            {
                var ExistEmployee = GetType(s => s.Id == entity.Id);
                ExistEmployee = entity;
                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
