
var eventNomi = new string[]
{
    "Mustaqillik kuni!",
    "O'qituvchi va Murabbiylar kuni",
    "O'zbekiston Respublikasi bayrog'i kuni",
    "Konstitutsiya kuni",
    "Yangi yil bayrami",
    "Vatan himoyachilari kuni",
    "Ayol va onalar kuni",
    "Navro'z bayrami",
    "Xotira va qadrlash kuni",
    "Bolalarni himoya qilish kuni"
};

var sanalar = new DateTime[]
{
    new DateTime(2023, 9, 1),
    new DateTime(2023, 10, 1),
    new DateTime(2023, 11, 18),
    new DateTime(2023, 12, 8),
    new DateTime(2023, 1, 1),
    new DateTime(2023, 1, 14),
    new DateTime(2023, 3, 8),
    new DateTime(2023, 3, 21),
    new DateTime(2023, 5, 9),
    new DateTime(2023, 6, 1),
};

while (true)
{
    Console.Write("1 - eventlarni saralash:\n2 - eventni nomi bo'yicha topish:\n3 - eventni vaqti bo'yicha topish:" +
        "\n4 - kelayotgan eventlari ko'rsatish (yaqinligi bo'yicha):\n5 - o'tib ketgan eventlarni ko'rsatish (yaqinligi bo'yicha):" +
        "\n6 - dasturni yopish:\nUser >>> ");
    var kiritilganBuyruqlar1 = int.Parse(Console.ReadLine());
    Console.Clear();
    if (kiritilganBuyruqlar1 == 1 || kiritilganBuyruqlar1 == 2 || kiritilganBuyruqlar1 == 3 || kiritilganBuyruqlar1 == 4 || kiritilganBuyruqlar1 == 5)
    {
        switch (kiritilganBuyruqlar1)
        {
            case 1:
                Console.Write("1 - nomi bo'yicha:\n2 - vaqti bo'yicha:\nUser >>> ");
                var kiritlganBuyruqlar2 = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (kiritlganBuyruqlar2)
                {
                    case 1:
                        Console.Write("1 - o'sish bo'yicha:\n2 - kamayish bo'yicha:\nUser >>> ");
                        var kiritilganBuyruqlar111 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (kiritilganBuyruqlar111)
                        {
                            case 1: //nomi va o'sish bo'yicha saralash
                                for (int i = 0; i < eventNomi.Length; i++)
                                {
                                    for (int j = 0; j < eventNomi.Length; j++)
                                    {
                                        if (eventNomi[i].CompareTo(eventNomi[j]) == -1)
                                        {
                                            var almashtirishUchunVaqtni = sanalar[i];
                                            var almashtirishUchun = eventNomi[i];

                                            eventNomi[i] = eventNomi[j];
                                            eventNomi[j] = almashtirishUchun;

                                            sanalar[i] = sanalar[j];
                                            sanalar[j] = almashtirishUchunVaqtni;
                                        }
                                    }
                                }

                                for (int i = 0; i < eventNomi.Length; i++)
                                {
                                    Console.WriteLine($"{eventNomi[i].ToString()} - {sanalar[i].ToString()}");
                                }
                                break;

                            case 2:
                                for (int i = 0; i < eventNomi.Length; i++)
                                {
                                    for (int j = 0; j < eventNomi.Length; j++)
                                    {
                                        if (eventNomi[i].CompareTo(eventNomi[j]) == 1)
                                        {
                                            var almashtirishUchunVaqtni = sanalar[i];
                                            var almashtirishUchun = eventNomi[i];

                                            eventNomi[i] = eventNomi[j];
                                            eventNomi[j] = almashtirishUchun;

                                            sanalar[i] = sanalar[j];
                                            sanalar[j] = almashtirishUchunVaqtni;
                                        }
                                    }
                                }

                                for (int i = 0; i < eventNomi.Length; i++)
                                {
                                    Console.WriteLine($"{eventNomi[i].ToString()} - {sanalar[i].ToString()}");
                                }
                                break;
                            default: break;
                        }
                        break;
                    case 2:
                        Console.Write("1 - o'sish bo'yicha:\n2 - kamayish bo'yicha:\nUser >>> ");
                        var kiritilganBuyruqlar112 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (kiritilganBuyruqlar112)
                        {
                            case 1:
                                Console.Clear();
                                for (int i = 0; i < eventNomi.Length ; i++)
                                {
                                    for (int j = 0; j < eventNomi.Length; j++)
                                    {
                                        if (sanalar[i].DayOfYear > sanalar[j].DayOfYear)
                                        {
                                            var almashtirishSanaUchun = sanalar[i];
                                            var almashtirishUchun = eventNomi[i];

                                            eventNomi[i] = eventNomi[j];
                                            eventNomi[j] = almashtirishUchun;

                                            sanalar[i] = sanalar[j];
                                            sanalar[j] = almashtirishSanaUchun;
                                        }
                                    }
                                }
                                for (int i = 0; i < eventNomi.Length; i++)
                                {
                                    Console.WriteLine($"{eventNomi[i].ToString()} - {sanalar[i].ToString()}");
                                }
                                break;
                            case 2:
                                Console.Clear();
                                for (int i = 0; i < eventNomi.Length; i++)
                                {
                                    for (int j = 0; j < eventNomi.Length; j++)
                                    {
                                        if (sanalar[i].DayOfYear < sanalar[j].DayOfYear)
                                        {
                                            var almashtirishSanaUchun = sanalar[i];
                                            var almashtirishUchun = eventNomi[i];

                                            eventNomi[i] = eventNomi[j];
                                            eventNomi[j] = almashtirishUchun;

                                            sanalar[i] = sanalar[j];
                                            sanalar[j] = almashtirishSanaUchun;
                                        }
                                    }
                                }
                                for (int i = 0; i < eventNomi.Length; i++)
                                {
                                    Console.WriteLine($"{eventNomi[i].ToString()} - {sanalar[i].ToString()}");
                                }
                                break;
                            default: break;
                        }
                        break;
                    default: break;
                }
                break;
            case 2:
                Console.Clear();
                Console.Write("Qidirmoqchi bo'lgan event nomini kiriting: ");
                var nomBoyichaQidirish = Console.ReadLine();
                for (int i = 0; i < eventNomi.Length; i++)
                {
                    if (eventNomi[i].Contains(nomBoyichaQidirish, StringComparison.OrdinalIgnoreCase))
                        Console.WriteLine($"{eventNomi[i]} - {sanalar[i]}");
                    break;
                }
                Console.WriteLine();
                break;
            case 3:
                Console.Clear();
                Console.Write("Qidirmoqchi bo'lgan event sanasini kiriting: ");
                var sanaBoyichaQidirish = Console.ReadLine();
                for (int i = 0; i < sanalar.Length; i++)
                {
                    if (Convert.ToString(sanalar[i]).Contains(sanaBoyichaQidirish))
                        Console.WriteLine($"{eventNomi[i]} - {sanalar[i]}");
                    break;
                }
                break;
            case 4:
                Console.Clear();
                for (int i = 0; i < eventNomi.Length; i++)
                {
                    if (sanalar[i].DayOfYear > DateTime.Now.DayOfYear)
                    {
                        Console.WriteLine($"{eventNomi[i]} - {sanalar[i]}");
                    }
                }
                Console.WriteLine();
                break;
            case 5:
                Console.Clear();
                for (int i = 0; i < eventNomi.Length; i++)
                {
                    if (sanalar[i].DayOfYear < DateTime.Now.DayOfYear)
                    {
                        Console.WriteLine($"{eventNomi[i]} - {sanalar[i]}");
                    }
                }
                Console.WriteLine();
                break;
        }
    }
    else
    {
        break;
    }
}