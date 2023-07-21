using static System.Runtime.InteropServices.JavaScript.JSType;

var eventlar = new string[5]
{
    "WoW 2.0 - Let's talk about Caching",
    "FrontSpot About new Angular features",
    "GDG - Google IO Extended",
    "AWS Tashkent - Develop your ML Project with Amazon SageMaker",
    "MDC - Sharpist hackathon"
};

var sanalar = new DateTime[5];
sanalar[0] = new DateTime(2023, 9, 23, 9, 0, 0);
sanalar[1] = new DateTime(2023, 8, 15, 11, 0, 0);
sanalar[2] = new DateTime(2023, 7, 30, 15, 0, 0);
sanalar[3] = new DateTime(2023, 9, 15, 9, 0, 0);
sanalar[4] = new DateTime(2023, 8, 10, 18, 0, 0);

for (int j = 0; j < 5; j++)
{
    for (int i = 0; i < 5; i++)
    {
        if (sanalar[j].Month < sanalar[i].Month)
        {
            var sanalar1 = sanalar[j];
            var eventSTR = eventlar[j];
            sanalar[j] = sanalar[i];
            eventlar[j] = eventlar[i];
            sanalar[i] = sanalar1;
            eventlar[i] = eventSTR;
        } else if (sanalar[j].Month == sanalar[i].Month)
        {
            if (sanalar[j].Day < sanalar[i].Day)
            {
                var sanalar1 = sanalar[j];
                var eventSTR = eventlar[j];
                sanalar[j] = sanalar[i];
                eventlar[j] = eventlar[i];
                sanalar[i] = sanalar1;
                eventlar[i] = eventSTR;
            }
        }
    }
}
while (true)
{
    Console.Write("Tilni tanlang:\n1-en:\n2-ru:\n3-uz:\n4-Exit:\nUser >>> ");
    int tilTanlov = int.Parse(Console.ReadLine());
    Console.Clear();
    if (tilTanlov == 1 || tilTanlov == 2 || tilTanlov == 3)
    {
        switch (tilTanlov)
        {
            case 1:
                Console.WriteLine("en");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{eventlar[i]} - {sanalar[i].ToString("dd.MM.yyyy hh:mm tt")}\n");
                }
                break;
            case 2:
                Console.WriteLine("ru");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{eventlar[i]} - {sanalar[i].ToString("dd/MM/yyyy")}\n");
                }
                break;
            case 3:
                Console.WriteLine("uz");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{eventlar[i]} - {sanalar[i].ToString("dd.MM.yyyy HH:mm")}\n");
                }
                break;
            default:
                Console.WriteLine("Noto'g'ri tilni tanladingiz!");
                break;
        }
    } else
    {
        break;
    }
}