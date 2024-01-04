namespace CompanyApp.Helpers
{
    public class Helper
    {
        public static void changeTextColor(string word, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(word);
            Console.ResetColor();
        }
    }
    public enum Catalog
    {
     CreateDepartment=1,
     GetAllDepartament=2,
     GetDepartmentById=3,
     GetAllDepartmentByCapacity=4,
     UpdateDepartment=5,
     DeleteDepartment=6,
     CreateEmployee=7,
     EmployeeDelete = 8,
     EmployeUpdate = 9,
     Get = 10,
     GetAll= 11,
     GetAllWithByName=12,
     GetAllWithByAge=13,
     GetWithByDepartmentId=14,
     GetWithByDepartamentName=15,
     exitCatalog=16,
    }
}
