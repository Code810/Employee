using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Domain.Interface
{
      interface ISearch
    {
        void SearchEmployee(DateTime min, DateTime max);
    }
}
