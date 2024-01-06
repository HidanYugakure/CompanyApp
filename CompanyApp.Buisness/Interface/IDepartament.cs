using CompanyApp.Domain.Models;

namespace CompanyApp.Buisness.Interface
{
    public interface IDepartament //imzalar
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
