// See https://aka.ms/new-console-template for more information
using CompanyApp.Buisness.Interface;
using CompanyApp.Domain.Models;
using CompanyApp.Helpers;

Department department = new Department();

while (true)
{
    Helper.changeTextColor("1. CreateDepartment\n" +
                        "2. GetAllDepartament\n" +
                        "3. GetDepartmentById\n" +
                        "4. GetAllDepartmentByCapacity \n" +
                        "5. UpdateDepartment\n" +
                        "6. DeleteDepartment\n", ConsoleColor.Magenta);

      Enter: string choice = Console.ReadLine();
      int result;
      bool isConvertable = int.TryParse(choice, out result);

      switch (result)
      {
        case (int)Catalog.CreateDepartment:
        
        default:
            Helper.changeTextColor("Wrong", ConsoleColor.Red);
            goto Enter;
      }
}

