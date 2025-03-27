using DolgozoProject.Models;

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
Console.WriteLine(anna.TimesPaid);