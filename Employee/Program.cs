
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

Persons mechanic1 = new(new DateTime(1991, 09, 01))
{
    Name = "Nadir",
    SurName = "Shirinbayli",
    Salary = 2500
};
mechanic1.EmployeeAdd(mechanic1);


Persons mechanic2 = new(new DateTime(1991, 09, 01))
{
    Name = "Samir",
    SurName = "Shirinbayli",
    Salary = 1900
};
mechanic1.EmployeeAdd(mechanic1);

mechanic1.SearchEmployee(new DateTime(1768, 09, 01), new DateTime(2022, 09, 01));



#endregion
