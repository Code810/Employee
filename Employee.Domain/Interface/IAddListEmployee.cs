using Employee.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Domain.Interface
{
     interface IAddListEmployee
    {
        Models.Persons[] EmployeeAdd(Models.Persons mechanic);
    }
}
