using System;

//Тут було порушено прицнип Liskov substitution

interface IShape
{
    int GetArea();
}

class Rectangle : IShape
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public Rectangle(int w, int h)
    {
        Width = w;
        Height = h;
    }

    public int GetArea()
    {
        return Width * Height;
    }
}

class Square : IShape
{
    public virtual int Side { get; set; }

    public Square(int s)
    {
        Side = s;
    }

    public int GetArea()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IShape rect = new Rectangle(5, 10);
        IShape square = new Square(6);

        Console.WriteLine(rect.GetArea());
        Console.WriteLine(square.GetArea());

        Console.ReadKey();
    }
}
