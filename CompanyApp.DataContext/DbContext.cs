using CompanyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApp.DataContext
{
    static class DbContext
    {

        public static List <Employee> Employees {  get; set; }
        public static List <Department> Departments { get; set; }
        static DbContext()
        {
            Employees = new List <Employee>();
            Departments = new List <Department>();
        }
    }
}
