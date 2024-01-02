using CompanyApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApp.Domain.Models
{
    public class Employee : BaseEntity
    {
      public string LastName { get; set; }
      public int Id { get; set; }
      public int Age { get; set; }
      public string Adress { get; set; } 
      public string Departament { get; set; }
    }
}
