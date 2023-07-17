using System.Diagnostics;

while (true)
{
    Console.Write("1-chi sonni kiriting: ");
    int son1 = int.Parse(Console.ReadLine());

    int summa = 0;

    Console.Write("Amallarni tanlang ( *, /, +, -, e): ");
    var amal = Console.ReadLine();
    if (amal == "/" || amal == "*" || amal == "-" || amal == "+")
    {
        Console.Write("2-chi sonni kiriting: ");
        int son2 = int.Parse(Console.ReadLine());

        switch(amal)
        {
            case "*":
                summa = son1 * son2;
                Console.WriteLine($"Natija: {summa}");
                break;
            case "/":
                summa = son1 / son2;
                Console.WriteLine($"Natija: {summa}");
                break;
            case "-":
                summa = son1 - son2;
                Console.WriteLine($"Natija: {summa}");
                break;
            case "+":
                summa = son1 + son2;
                Console.WriteLine($"Natija: {summa}");
                break;
        }
    } 
    else 
    {
        break;
    }
}