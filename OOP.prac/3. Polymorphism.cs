namespace OOP.prac;

// Method Overloading (Compile-time)
static class Calculator
{
    public static int Mathfunct(int a, int b)
    {
        return a * b;
    }

    public static int Mathfunct(int a, int b, int c)
    {
        return a + b + c;
    }

    public static int Mathfunct(int a, int b, int c, int d)
    {
        return a - b - c - d;
    }
}

// Method Overriding (Runtime)
class Vehicle
{
    // Virtual method to allow overriding
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

// Derived class
class Motorcycle : Vehicle
{
    // Overriding the base class method
    public override void MakeSound()
    {
        Console.WriteLine("Motorcycle makes a sound");
    }
}

// Derived class
class Car : Vehicle
{
    // Overriding the base class method
    public override void MakeSound()
    {
        Console.WriteLine("Car  makes a sound");
    }
}