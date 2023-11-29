
using Employee.Domain.Services;

Celcius celcius1 = new(13);
Kelvin kelvin1 = celcius1;
Console.WriteLine(kelvin1.Degree);
Celcius celcius2 = kelvin1;
Console.WriteLine(celcius2.Degree);