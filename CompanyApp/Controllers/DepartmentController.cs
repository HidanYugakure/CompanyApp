using CompanyApp.Buisness.Services;
using CompanyApp.Domain.Models;
using CompanyApp.Helpers;

namespace CompanyApp.Controllers
{
    public class DepartmentController
    {
        private readonly DepartmentService departmentServices;
        public DepartmentController()
        {
            departmentServices = new DepartmentService();
        }
        public void CreateDepartment()
        {
            Helper.changeTextColor("Please Enter Departament Name", ConsoleColor.Magenta);
            string Departamentname = Console.ReadLine();
            Helper.changeTextColor("Please Enter Department Employee Name", ConsoleColor.Magenta);
            string size = Console.ReadLine();
            bool result = int.TryParse(size, out int DepartamentSize);
            if (result)
            {
                Department departament = new();
                departament.Name = Departamentname;
                departament.Capacity = DepartamentSize;
                Department createdDepartament = departmentServices.Create(departament);
                if (createdDepartament is not null)
                {
                    Helper.changeTextColor($"{departament.Name} created succesfully ", ConsoleColor.Green);
                }
                else
                {
                    Helper.changeTextColor("something went wrong", ConsoleColor.DarkRed);
                }
            }
            else
            {
                Helper.changeTextColor("write size of Departament properly", ConsoleColor.Red);
            }
        }
            public void GetAllDepartament()
            {
                Helper.changeTextColor("Departament list :", ConsoleColor.Red);
                List<Department> departments = departmentServices.GetAll();
                if (departments.Count > 0)
                {
                    foreach (var department in departments)
                    {
                        Helper.changeTextColor($"id:{department.Id} name: {department.Name} size :{department.Capacity}", ConsoleColor.Blue);

                    }
                }
                else
                {
                    Helper.changeTextColor("empty",ConsoleColor.Red);
                }
            } }
            public void UpdateDepartment()
            {
                Helper.changeTextColor(ConsoleColor.Magenta, "enter Id");
                int id = int.Parse(Console.ReadLine());
                Helper.changeTextColor(ConsoleColor.Magenta, "enter size");
                int size = int.Parse(Console.ReadLine());
                Helper.changeTextColor(ConsoleColor.Green, "enter DepartamentName ");
                string Groupname = Console.ReadLine();
                Department department = new();

                department.Name = Groupname;
                department.size = size;
                Department createdDepartament = departamentService.update(id, department);
                if (createdDepartament != null)
                {
                    Helper.changeTextColor(ConsoleColor.Blue, $"{department.Name} uptaded succesfully ");

                }
                else
                {
                    Helper.changeTextColor(ConsoleColor.Red, "wrong ");
                }
            }
            public void DeleteDepartment()
            {
                Helper.changeTextColor(ConsoleColor.Blue, "enter Id");
                int id = int.Parse(Console.ReadLine());
                Department result = departmentService.Delete(id);
                if (result == null)
                {
                    Helper.changeTextColor(ConsoleColor.Red, "something went wrong");
                }
                else
                {
                    Helper.changeTextColor(ConsoleColor.Red, "Employee deleted");
                }
            }
        } 
      }
    }

