var savollar = new string[]
{
    "O'zbekiston Respublikasining poytaxti qayer?",
    "O'zbekistonda nechta viloyat majvud?",
    "O'zbekiston Respublikasi bayrog'ida nechta rang bor?",
    "O'zbekistonning davlat shakli?",
    "O'zbekitonni kim boshqaradi?"
};

var javoblar = new string[]
{
    "Toshkent", "Samarqand",
    "14", "12",
    "6", "4",
    "Respublika", "Monarx",
    "Qirol", "Prezident"
};

var t_javoblar = new string[]
{
    "Toshkent",
    "12",
    "4",
    "Respublika",
    "Prezident"
};

var ball = 0;
var k_javoblar = new string[5];

for (int i = 0; i < savollar.Length; i++)
{
    Console.Write($"{i+1}.{savollar[i]}\nA){javoblar[i+i]} B){javoblar[i+i+1]}\nUser: ");
    k_javoblar[i] = Console.ReadLine();
}

var x_javoblar = new string[5];

for  (int i = 0; i < k_javoblar.Length; i++)
{
    if (i == 0 && k_javoblar[i] == "A")
        ball += 5;
    else if (i == 1 && k_javoblar[i] == "B")
        ball += 5;
    else if (i == 2 && k_javoblar[i] == "B")
        ball += 5;
    else if (i == 3 && k_javoblar[i] == "A")
        ball += 5;
    else if (i == 4 && k_javoblar[i] == "B")
        ball += 5;
    else
        x_javoblar[i] = savollar[i];
}

Console.WriteLine($"Ball:{ball}");
Console.WriteLine("Invalid answers:");



for (int i = 0; i < x_javoblar.Length; i++)
{
    if (x_javoblar[i] != null)
        Console.Write($"Question: {x_javoblar[i]}\nAnswer: {t_javoblar[i]}\n");
}