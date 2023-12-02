
using Employee.Domain.Interface;
using Employee.Domain.Models;
using Employee.Domain.Services;

#region task1
//Celcius celcius1 = new(13);
//Kelvin kelvin1 = celcius1;
//Console.WriteLine(kelvin1.Degree);
//Celcius celcius2 = kelvin1;
//Console.WriteLine(celcius2.Degree);
#endregion

#region task2

Persons person1 = new(new DateTime(2003, 09, 01))
{
    Name = "Nadir",
    SurName = "Shirinbayli",
    Salary = 2500,
};
person1.AgeCaculate();
person1.EmployeeAdd(person1);

Persons person2 = new(new DateTime(1998, 11, 01))
{
    Name = "Name2",
    SurName = "Surname2",
    Salary = 2500,
};
person2.AgeCaculate();
person2.EmployeeAdd(person2);

Persons person3 = new(new DateTime(1992, 11, 01))
{
    Name = "Name3",
    SurName = "Surname3",
    Salary = 2500,
};
person3.AgeCaculate();
person3.EmployeeAdd(person3);

person3.SearchEmployeeCount(new DateTime(1991, 01, 01), new DateTime(2002, 12, 01),2000);




#endregion
