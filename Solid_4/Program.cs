using System;

/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/

//Тут було порушено принцип Interface segregation

interface IStructureProduct
{
    void SetColor(byte color);
    void SetSize(byte size);
}

interface IDiscountProduct
{
    void ApplyDiscount(string discount);
    void ApplyPromocode(string promocode);
}

interface ISellProduct
{
    void SetPrice(double price);
}

class Book : ISellProduct, IDiscountProduct
{
    private double Price { get; set; }
    private string Discount { get; set; }
    private string Promocode { get; set; }

    public void SetPrice(double price)
    {
        Price = price;
        Console.WriteLine($"Setted price of book: {Price}");
    }

    public void ApplyDiscount(string discount)
    {
        Discount = discount;
        Console.WriteLine($"To book applied discount: {Discount}");
    }

    public void ApplyPromocode(string promocode)
    {
        Promocode = promocode;
        Console.WriteLine($"To book applied promocode: {Promocode}");
    }
}

class Outerwear : IStructureProduct, ISellProduct, IDiscountProduct
{
    private double Price { get; set; }
    private string Discount { get; set; }
    private string Promocode { get; set; }
    private byte Color { get; set; }
    private byte Size { get; set; }

    public void SetPrice(double price)
    {
        Price = price;
        Console.WriteLine($"Setted price of outerwear: {Price}");
    }

    public void ApplyDiscount(string discount)
    {
        Discount = discount;
        Console.WriteLine($"To outerwear applied discount: {Discount}");
    }

    public void ApplyPromocode(string promocode)
    {
        Promocode = promocode;
        Console.WriteLine($"To outerwear applied promocode: {Promocode}");
    }

    public void SetColor(byte color)
    {
        Color = color;
        Console.WriteLine($"The color of outerwear: {Color}");
    }

    public void SetSize(byte size)
    {
        Size = size;
        Console.WriteLine($"The size of outerwear: {Size}");
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Console.ReadKey();
    }
}