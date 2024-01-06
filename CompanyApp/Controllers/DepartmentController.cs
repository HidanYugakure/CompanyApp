using CompanyApp.Buisness.Services;
using CompanyApp.Domain.Models;
using CompanyApp.Helpers;
namespace CompanyApp.Controllers  
{   public class DepartmentController
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
            Helper.changeTextColor("Please Enter Department Size", ConsoleColor.Magenta);
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
                Helper.changeTextColor("empty", ConsoleColor.Red);
            }
        }
        public void GetDepartmentById()
        {
            Helper.changeTextColor("Departament by Id :", ConsoleColor.Yellow);
            int id = int.Parse(Console.ReadLine());
            Department department=departmentServices.Get(id);

            if (department != null) 
            {
                Helper.changeTextColor($"{department.Id}, {department.Name}", ConsoleColor.Yellow);
            }
            else
            {
                Helper.changeTextColor("empty", ConsoleColor.Red);
            }
        }
        public void GetAllDepartmentByCapacity()
        {
            Helper.changeTextColor("Enter A Capacity", ConsoleColor.Magenta);
            int capacity = int.Parse(Console.ReadLine());
            List<Department> departments = departmentServices.GetAll(capacity);
            foreach (Department department in departments)
            {
                Helper.changeTextColor($"Capacity:{department.Capacity} name: {department.Name}", ConsoleColor.Blue);
            }
        }
        public void UpdateDepartment()
        {
            Helper.changeTextColor("enter Id", ConsoleColor.Magenta);
            int id = int.Parse(Console.ReadLine());
            Helper.changeTextColor("enter size", ConsoleColor.Magenta);
            int size = int.Parse(Console.ReadLine());
            Helper.changeTextColor("enter DepartamentName ", ConsoleColor.Green);
            string Groupname = Console.ReadLine();
            Department department = new();

            department.Name = Groupname;
            department.Capacity = size;
            Department createdDepartament = departmentServices.Update(id, department);
            if (createdDepartament != null)
            {
                Helper.changeTextColor($"{department.Name} uptaded succesfully ", ConsoleColor.Blue);

            }
            else
            {
                Helper.changeTextColor("wrong ", ConsoleColor.Red);
            }
        }
        public void DeleteDepartment()
        {
            Helper.changeTextColor("enter Id", ConsoleColor.Blue);
            int id = int.Parse(Console.ReadLine());
            Department result = departmentServices.Delete(id);
            if (result == null)
            {
                Helper.changeTextColor("something went wrong", ConsoleColor.Red);
            }
            else
            {
                Helper.changeTextColor("Employee deleted", ConsoleColor.Red);
            }
        }
    }
}