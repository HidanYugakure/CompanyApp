using CompanyApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApp.DataContext.Interface
{
    public interface  IRepositories <in T> where T : BaseEntity 
    {
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
