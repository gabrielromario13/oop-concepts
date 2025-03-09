namespace OOP.prac;

// Method Overloading (Compile-time)
internal static class Calculator
{
    public static int Mathfunct(int a, int b) => a + b;

    public static int Mathfunct(int a, int b, int c) => a + b + c;

    public static int Mathfunct(int a, int b, int c, int d) => a + b + c + d;
}

// Method Overriding (Runtime)
internal class Vehicle
{
    // Virtual method to allow overriding
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

// Derived class
internal class Motorcycle : Vehicle
{
    // Overriding the base class method
    public override void MakeSound() => Console.WriteLine("Motorcycle makes a sound");
}

// Derived class
internal class Car : Vehicle
{
    // Overriding the base class method
    public override void MakeSound() => Console.WriteLine("Car makes a sound");
}