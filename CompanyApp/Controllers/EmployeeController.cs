using CompanyApp.Buisness.Interface;
using CompanyApp.Buisness.Services;
using CompanyApp.Domain.Models;
using CompanyApp.Helpers;


namespace CompanyApp.Controllers
{
    public class EmployeeController
    {
        private readonly EmployeeService employeeServices;
        public void CreateEmployee()
        {
            Helper.changeTextColor("enter Employee Name", ConsoleColor.Magenta);
            string name = Console.ReadLine();
            Helper.changeTextColor("enter Employee LastName", ConsoleColor.Magenta);
            string Surname = Console.ReadLine();
            Helper.changeTextColor("enter Department", ConsoleColor.Green);
            string Departamentname = Console.ReadLine();
            Employee employee = new();
            employee.Name = name;
            employee.LastName = Surname;
            //_employeeService.Create(employee, Departamentname);
            if (employeeServices.Create(employee, Departamentname) is null)
            {
                Helper.changeTextColor("went wrong", ConsoleColor.Red);
            }
            else
            {
                Helper.changeTextColor("succesfully created",ConsoleColor.Red);
            }
        }
        public void EmployeeDelete()
        {
            Helper.changeTextColor("enter Id", ConsoleColor.Magenta);
            int id = int.Parse(Console.ReadLine());
            var result = employeeServices.Delete(id);
            if (result == null)
            {
                Helper.changeTextColor("something went wrong", ConsoleColor.Red);
            }
            else
            {
                Helper.changeTextColor("employee deleted", ConsoleColor.Red);
            }
        }
        public void EmployeUpdate()
        {
            Helper.changeTextColor("Enter Id", ConsoleColor.Blue);
            int id = int.Parse(Console.ReadLine());
            Helper.changeTextColor("enter new Employee Name", ConsoleColor.Blue);
            string name = Console.ReadLine();
            Helper.changeTextColor("enter new Employee LaStName", ConsoleColor.Blue);
            string Surname = Console.ReadLine();
            Helper.changeTextColor("Enter Departament Name", ConsoleColor.Green);
            string Departamentname = Console.ReadLine();
            Employee employee = new();
            employee.Name = name;
            employee.LastName = Surname;
            //employeeServices.Create(employee, departmentname);
            if (employeeServices.Update(id, employee, Departamentname) is null)
            {
                Helper.changeTextColor("went wrong", ConsoleColor.Red);
            }
            else
            {
                Helper.changeTextColor("succesfully updated", ConsoleColor.Green);
            }
        }
        public void  Get ()
        {
            Helper.changeTextColor("Employee by Id :", ConsoleColor.Yellow);
            int Id = int.Parse(Console.ReadLine());
            Employee employee = employeeServices.Get(Id);
            if (employee != null)
            {
                Helper.changeTextColor($"{employee.Id}, {employee.Name}", ConsoleColor.Yellow);
            }
            else
            {
                Helper.changeTextColor("empty", ConsoleColor.Red);
            }
        }
        public void GetAllWithByName()
        {
            Helper.changeTextColor("Employee list : Name", ConsoleColor.Red);
            List<Employee> employee = employeeServices.GetAll();
            foreach (Employee employees in employee)
            {
                Helper.changeTextColor($"{employees.Id},{employees.Name}", ConsoleColor.Yellow);
            }
        }
        public void GetAllWithByAge()
        {
            Helper.changeTextColor("Employee list: Age", ConsoleColor.Green);
            List<Employee> employee = employeeServices.GetAll();
            foreach(Employee employees in employee)
            {
                Helper.changeTextColor($"{employees.Id},{employees.Name},{ employees.Age}", ConsoleColor.Yellow);
            }
        }
        public void GetWithByDepartmentId() 
        {
            Helper.changeTextColor("Enter Departament Id:", ConsoleColor.Green);
            string DepartamentId = Console.ReadLine();
            var something = employeeServices.GetEmployeeDepartmentId(DepartamentId);
            foreach (var item in something)
            {
                Console.WriteLine($"id:{item.Id}Name:{item.Name} ");
            }
        }
    }
}
