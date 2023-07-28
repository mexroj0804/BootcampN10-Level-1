//-Shape tipidan foydalaning
//- unda CalculateArea methodi bo'lsin
//- Shape tipidan vorislik olgan Triangle, Rectangle, Circle tiplari bo'lsin
//- ularda CalculateArea methodini override qiling
//- 3 ta tipdan object olib, CalculateArea orqali yuzasini hisoblab, ekranga chiqaring

using System.Runtime.InteropServices;

Shape dastur1 = new Triangle();
dastur1.CalculateArea(12);

Shape dastur2 = new Rectangle();
dastur2.CalculateArea(20);

Shape dastur3 = new Circle();
dastur3.CalculateArea(16);
public class Shape
{
    public virtual void CalculateArea(int uzunligi)
    {
    }
}

public class Triangle : Shape
{
    public override void CalculateArea(int uzunligi)
    {
        Console.WriteLine((uzunligi * uzunligi) / 2);
    }
}

public class Rectangle : Shape
{
    public override void CalculateArea(int uzunligi)
    {
        Console.WriteLine(uzunligi * uzunligi);
    }
}

public class Circle : Shape
{
    public override void CalculateArea(int radiusi)
    {
        Console.WriteLine(3.14 * (radiusi * radiusi));
    }
}