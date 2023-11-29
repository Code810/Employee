using Employee.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Domain.Models
{
    public class Persons:ISearch,IAddListEmployee, IAgeCaculate
    {
        private static int _id;
        public int Id  { get; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public int Salary { get; set; }

        public static Persons[] ListOfMechanic = new Persons[16];
        public Persons(DateTime birthday)
        {
            Birthday=birthday;
            _id++;
            Id = _id;
            Age = AgeCaculate();
        }

        public void SearchEmployee(DateTime min,DateTime max)
        {
            foreach (var item in ListOfMechanic)
            {
                if(item.Birthday.Year>min.Year &&  item.Birthday.Year<max.Year)
                {
                    if (item.Salary>2000)
                    {
                        Console.WriteLine($"Id:{Id} Name:{Name} Surname:{SurName}");
                    }
                }
            }

            
        }

        public Persons[] EmployeeAdd(Persons mechanic)
        {
            
            ListOfMechanic[mechanic.Id-1]=mechanic;
            return ListOfMechanic;
        }

        public int AgeCaculate()
        {
            
            int age = (int)((DateTime.Now - Birthday).TotalDays / 365.242199);
           return age;
        }
    }
}
