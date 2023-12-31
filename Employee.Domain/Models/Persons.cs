﻿using Employee.Domain.Interface;


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

        private static  Persons[] ListOfMechanic = new Persons[0];
        public Persons(DateTime birthday)
        {
            Birthday=birthday;
            _id++;
            Id = _id;
        }

        public void SearchEmployeeCount(DateTime min,DateTime max,int salary)
        {
            int count = 0;
            foreach (var item in ListOfMechanic)
            {
                if(item.Birthday>min &&  item.Birthday<max&& item.Salary > salary)
                {
                        count++;
                }
            }

            Console.WriteLine(count);
        }

        public void EmployeeAdd(Persons mechanic)
        {
            Array.Resize(ref ListOfMechanic, ListOfMechanic.Length + 1);
            ListOfMechanic[ListOfMechanic.Length-1] = mechanic;
        }

        public void AgeCaculate()
        {
            int age = (int)((DateTime.Now - Birthday).TotalDays / 365.242199);
            Age= age;
        }
    }
}
