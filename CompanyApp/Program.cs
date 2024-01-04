// See https://aka.ms/new-console-template for more information
using CompanyApp.Buisness.Interface;
using CompanyApp.Controllers;
using CompanyApp.Domain.Models;
using CompanyApp.Helpers;
using System;

Department department = new Department();
DepartmentController departmentController = new DepartmentController();
EmployeeController employeeController = new EmployeeController();
Employee employee = new Employee();

while (true)
{
    Helper.changeTextColor("1. CreateDepartment\n" +
                        "2. GetAllDepartament\n" +
                        "3. GetDepartmentById\n" +
                        "4. GetAllDepartmentByCapacity \n" +
                        "5. UpdateDepartment\n" +
                        "6. DeleteDepartment\n" +
                        "7.CreateEmployee\n" +
                        "8.EmployeeDelete\n" +
                        "9.EmployeUpdate\n" +
                        "10.Get\n" +
                        "11.GetAll\n " +
                        "12.GetAllWithByName\n " +
                        "13.GetAllWithByAge\n " +
                        "14.GetWithByDepartmentId\n" +
                        "15GetWithByDepartamentName\n" +
                        "16.exitMenu", ConsoleColor.Magenta);

    //Enter: string choice = Console.ReadLine();
    //    int result;
    //    bool isConvertable = int.TryParse(choice, out result);

    //    switch (result)
    //    {
    //        case (int)Catalog.CreateDepartment:

    //        default:
    //            Helper.changeTextColor("Wrong", ConsoleColor.Red);
    //            goto Enter;
    //    }
    //}
    string catalog = Console.ReadLine();
    bool result = int.TryParse(catalog, out int intcatalog);
    if (result && intcatalog > 0 && intcatalog < 16)
    {
        switch (intcatalog)
        {
            case (int)Catalog.CreateDepartment:
                departmentController.CreateDepartment();
                break;
            case (int)Catalog.GetAllDepartament:
                departmentController.GetAllDepartament();
                break;
            case (int)Catalog.GetDepartmentById:
                departmentController.GetDepartmentById();
                break;
            case (int)Catalog.GetAllDepartmentByCapacity:
                departmentController.GetAllDepartmentByCapacity();
                break;
            case (int)Catalog.UpdateDepartment:
                departmentController.UpdateDepartment();
                break;
            case (int)Catalog.DeleteDepartment:
                departmentController.DeleteDepartment();
                break;
            case (int)Catalog.CreateEmployee:
                employeeController.CreateEmployee();
                break;
            case (int)Catalog.EmployeeDelete: employeeController.EmployeeDelete();
                break;
            case (int)Catalog.EmployeUpdate: employeeController.EmployeUpdate();
                break;
            case (int)Catalog.Get:
                employeeController.Get();
                break;
            case (int)Catalog.GetAll:
                employeeController.GetAll();
                break;
            case (int)Catalog.GetAllWithByName:
                employeeController.GetAllWithByName();
                break;
            case (int)Catalog.GetAllWithByAge:
                employeeController.GetAllWithByAge();
                break;
            case (int)Catalog.GetWithByDepartmentId:
                employeeController.GetWithByDepartmentId();
                break;
            case (int)Catalog.GetWithByDepartamentName:
                employeeController.GetWithByDepartamentName();
                break;
        } 
    }
    else if  (intcatalog == 17)
    {
        Helper.changeTextColor("you left the catalog", ConsoleColor.Red);
        break;

    }
    else
    {
        Helper.changeTextColor("pleasy try true number", ConsoleColor.Red);
    }
    }





