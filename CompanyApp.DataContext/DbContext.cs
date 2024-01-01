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

        public static List <Employee> employee {  get; set; }
        public static List <Department> department { get; set; }
        static DbContext()
        {
            employee = new List <Employee>();
            department = new List <Department>();
        }
    }
}
