
Person dastur = new Person("Mexroj", 19);
Person dastur1 = new Person(age: 20, name: "Azizbek", ismarried: true);
dastur.DisplayInfo();
Console.WriteLine();
dastur1.DisplayInfo();

public class Person
{
    private string Name;
    private byte Age;
    private bool IsMarried;

    public Person(string name, byte age, bool ismarried = false)
    {
        Name = name;
        Age = age;
        IsMarried = ismarried;
    }

    public void DisplayInfo()
    {
        if (IsMarried)
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nIsMarried: Oilali!");
        else
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nIsMarried: Oilali emas!");

    }
}