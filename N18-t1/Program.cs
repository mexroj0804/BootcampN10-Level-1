
Malibu malibu = new Malibu("GM", 2020, "Qora");
malibu.Show();

Captiva captiva = new Captiva("Chevrolet", 2022, "Oq");
captiva.Show();

//malibu.Drive();
captiva.Drive();

public abstract class Car
{
    public string BrandName { get; init; }
    public int Year { get; init; }
    public string Colour { get; set; }

    public virtual void Show()
    {
        Console.WriteLine($"Brand nomi: {BrandName}\nYili: {Year}\nRangi: {Colour}");
    }

    public abstract void Drive();
}

public class Malibu : Car
{
    public static int passsangers;
    public readonly int maxSpeed;

    public Malibu(string brand, int year, string colour)
    {
        passsangers = 4;
        maxSpeed = 200;
        base.Colour = colour;
        base.BrandName = brand;
        base.Year = year;
    }
    public override void Show()
    {
        Console.WriteLine($"Malibu:\nBrand nomi: {BrandName}\nYili: {Year}\nRangi: {Colour}" +
            $"\nOdamlar sig'imi: {passsangers}\nMaksimal tezligi: {maxSpeed}");
    }

    public override void Drive()
    {
        Random rd = new Random();
        var startSpeed = 0;

        while(startSpeed <= 100)
        {
            startSpeed += rd.Next(0, 10);
            Show();
            Console.WriteLine($"Speed: {startSpeed}");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}

public class Captiva : Car
{
    public static int passangers;
    public readonly int maxSpeed;

    public Captiva(string brand, int year, string colour)
    {
        passangers = 4;
        maxSpeed = 220;
        base.Colour = colour;
        base.BrandName = brand;
        base.Year = year;
    }
    public override void Show()
    {
        Console.WriteLine($"Captiva:\nBrand nomi: {BrandName}\nYili: {Year}\nRangi: {Colour}" +
            $"\nOdamlar sig'imi: {passangers}\nMaksimal tezligi: {maxSpeed}");
    }

    public override void Drive()
    {
        Random rd = new Random();
        var startSpeed = 0;

        while (startSpeed <= 100)
        {
            Show();
            Console.WriteLine($"Speed: {startSpeed}");
            Thread.Sleep(1000);            
            Console.Clear();
            startSpeed += rd.Next(0, 10);
        }
    }
}