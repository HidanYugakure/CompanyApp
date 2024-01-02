using CompanyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApp.Buisness.Interface
{
    public interface IDepartament
    {
        Department Create(Department department);
        Department Update(int id,Department department);
        Department Delete(int id);

        Department Get(int id);
        List<Department> GetAll(string name);
        List<Department> GetAll(int capacity);
        List <Department> GetAll();
    }
}
