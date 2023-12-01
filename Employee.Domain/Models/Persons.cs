using Employee.Domain.Interface;


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

        public void SearchEmployee(DateTime min,DateTime max)
        {
            foreach (var item in ListOfMechanic)
            {
                if(item.Birthday>min &&  item.Birthday<max)
                {
                    if (item.Salary>2000)
                    {
                        Console.WriteLine($"Id:{item.Id} Name:{item.Name} Surname:{item.SurName} Age:{item.Age}");
                    }
                }
            }

            
        }

        public void EmployeeAdd(Persons mechanic)
        {

            Array.Resize(ref ListOfMechanic, ListOfMechanic.Length + 1);
            ListOfMechanic[ListOfMechanic.Length-1] = mechanic;
        }

        public int AgeCaculate()
        {
            
            int age = (int)((DateTime.Now - Birthday).TotalDays / 365.242199);
            Age= age;
           return age;
        }
    }
}
