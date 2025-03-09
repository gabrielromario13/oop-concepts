namespace OOP.prac;

// Single Inheritance
internal class Animal
{
    public void Eat() => Console.WriteLine("Animal is eating");
}

internal class Dog : Animal
{
    public void Bark() => Console.WriteLine("Dog is barking.");
}

// Multi-level Inheritance
internal class Mammal : Animal
{
    public void Run() => Console.WriteLine("Mammal is running.");
}

internal class Horse : Mammal
{
    public void Gallop() => Console.WriteLine("Horse is galloping.");
}

// Hierarchical Inheritance
internal class Bird : Animal
{
    public static void Fly() => Console.WriteLine("Bird is flying.");
}

internal class Eagle : Bird
{
    public void Hunt() => Console.WriteLine("Eagle is hunting.");
}

internal class Penguin : Bird
{
    public void Swim() => Console.WriteLine("Penguin is swimming.");
}

// Multiple Inheritance using Interfaces
internal interface I1
{
    void Method1();
}

internal interface I2
{
    void Method2();
}

public class MyClass : I1, I2
{
    public void Method1() => Console.WriteLine("MyClass is called.");

    public void Method2() => Console.WriteLine("MyClass is called.");
}