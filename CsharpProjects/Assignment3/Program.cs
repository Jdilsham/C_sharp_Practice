using System;

public class Program
{
    public static void Main(string[] args)
    {
        Employee e1 = new Employee();

        Programmer p1 = new Programmer();
        float totalSalary = p1.salary + p1.bonus;
        Console.WriteLine("Total Salary: " + totalSalary);

    }
}

public class Employee
{
    public float salary = 40000;
    public Employee()
    {
        Console.WriteLine("Default Constructor");

    }

}

public class Programmer : Employee
{
    public float bonus = 10000;
}