using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Employee e1 = new Employee();

        //Programmer p1 = new Programmer();
        //float totalSalary = p1.salary + p1.bonus;
        //Console.WriteLine("Total Salary: " + totalSalary);

        Dog dog = new Dog();
        dog.eat();
        dog.bark();

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

public class Animal()
{
    public void eat()
    {
        Console.WriteLine("Eating...");
    }
}

public class Dog : Animal
{
    public void bark()
    {
        Console.WriteLine("Barking...");
    }
}