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

        bool IRepositories<Employee>.Create(Employee entity)
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

        bool IRepositories<Employee>.Delete(Employee entity)
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

        bool IRepositories<Employee>.Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
