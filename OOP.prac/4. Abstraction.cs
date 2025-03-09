namespace OOP.prac;

// 4.1 Using Abstract Classes
internal abstract class Shape
{
    public abstract int Area();
}

internal class Square(int x = 0) : Shape
{
    private int _side = x;

    public override int Area()
    {
        Console.Write("Area of Square: ");
        return _side * _side;
    }
}

// 4.2 Using Interfaces
public interface IStudent
{ 
    void FavSubject();
}

public class Geeky : IStudent
{
    public void FavSubject() => Console.WriteLine("My favorite subject is C#");
}