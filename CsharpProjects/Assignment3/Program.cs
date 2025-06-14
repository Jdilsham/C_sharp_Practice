﻿using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Employee e1 = new Employee();

        //Programmer p1 = new Programmer();
        //float totalSalary = p1.salary + p1.bonus;
        //Console.WriteLine("Total Salary: " + totalSalary);

        //Dog dog = new Dog();
        //dog.eat();
        //dog.bark();

        //Console.WriteLine(cal.add(1, 2));
        //Console.WriteLine(cal.add(2, 3, 4));


        //Dogs dogs = new Dogs();
        //dogs.eat();

        /*Shape s;
        s = new Shape();
        s.draw();

        s = new Rectangle();
        s.draw();

        s = new Circle();
        s.draw();
        */


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

public class Cal()
{
    public static int add(int a, int b)
    {
        return a + b;
    }

    public static int add(int a, int b, int c)
    {
        return a + b + c;
    }
}

public class Animals()
{
    public virtual void eat()
    {
        Console.WriteLine("Eating...");
    }
}

public class Dogs : Animals
{
    public override void eat()
    {
        Console.WriteLine("Eating Bread...");
    }
}


public class Shape
{
    public virtual void draw()
    {
        Console.WriteLine("Drawing...");
    }
}

public class Rectangle : Shape
{
    public override void draw()
    {
        Console.WriteLine("Drawing Rectangle...");
    }
}

public class Circle : Shape
{
    public override void draw()
    {
        Console.WriteLine("Drawing Circle...");
    }
}

