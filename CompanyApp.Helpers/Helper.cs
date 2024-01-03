using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
