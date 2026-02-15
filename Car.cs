using System;
public class Car
{
    public string Make;
    public string Model;
    public int Year;

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;

    }

    public void PrintInfo()
    {
        Console.WriteLine($"This car is a {Year} {Make} {Model}.");
    }
}

public class Program
{
    public static void Main()
    {
        Car myCar = new Car("Toyota", "Prius", 2011);

        myCar.PrintInfo();
    }
}