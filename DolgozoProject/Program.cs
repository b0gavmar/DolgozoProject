﻿using DolgozoProject.Models;
using DolgozoProject.Repos;

try
{
    Employee emptye = new Employee("", "John Doe");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
Employee anna = new Employee("nagy.anna@munkahely.com","Nagy Anna");
try
{
    anna.IncreaseSalary(-5000);
}catch(Exception e)
{
    Console.WriteLine(e.Message);
}
anna.IncreaseSalary(25000);
anna.IncreaseSalary(40000);
Console.WriteLine(anna);
Console.WriteLine($"{anna.Adokulcs}; { anna.Ado}");
//Console.WriteLine(anna.TimesPaid);

DolgozokRepo repo = new DolgozokRepo(new DolgozokContext());
Console.WriteLine("1");
Console.WriteLine(await repo.GetNumberOfEmployees());
foreach(Employee e in await repo.GetAll())
{
    Console.WriteLine(e);
}
Console.WriteLine("2");
foreach (Employee e in await repo.GetAllHigherThan(48000))
{
    Console.WriteLine(e);
}
Console.WriteLine("3");
foreach (Employee e in await repo.OrderedBySalary())
{
    Console.WriteLine(e);
}
Console.WriteLine("4");
repo.AvgAndSum();
Console.WriteLine("5");
foreach (KeyValuePair<string,int> kvp in await repo.GroupBySalary())
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}