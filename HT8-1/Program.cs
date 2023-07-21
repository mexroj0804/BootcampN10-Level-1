using System.Numerics;

var ismlar = new LinkedList<string>();
ismlar.AddFirst("Jasur");
ismlar.AddLast("Akbar");
ismlar.AddLast("Azizbek");
ismlar.AddLast("Asilbek");


var samalyotlar = new Dictionary<TimeOnly, int>();
samalyotlar.Add(new TimeOnly(05, 30), 4);
samalyotlar.Add(new TimeOnly(10, 25), 7);
samalyotlar.Add(new TimeOnly(14, 00), 2);

var Emails = new LinkedList<string>();
Emails.AddFirst("Hello {{Name}}. Welcome to onboard. {{CompanyName}} Team.");
Emails.AddLast("Your data is being processed and we will inform updates " +
    "for you as soon as possible. {{CompanyName}} Team");
Emails.AddLast("Congratulations! Your flight ticket is booked for " +
    "{{TicketDate}}. {{CompanyName}} Team.");

var CompanyName = "{{CompanyName}}";
var NameToken = "{{Name}}";
var CompanyNameToken = "{{CompanyNameToken}}";
var TicketDateToken = "{{TicketDateToken}}";


string massageUnderAge = "Uzr, hurmatli {{Name}} siz loyidan foydalanish uchun kichkinasiz!";
string massageGoldenAger = "Uzr, hurmatli {{Name}} loyiha yoshlar uchun mo'ljallangan";


while (true)
{
    Console.Write("1-Ro'yxatdan o'tish jarayoni:\n2-Biletlarni olish " +
        "jarayoni:\n3-Loyihani boshlash:\n4-Exit:\nUser >>> ");
    int UserTanlovi = int.Parse(Console.ReadLine());

    if (UserTanlovi == 1 || UserTanlovi == 2 || UserTanlovi == 3)
    {
        switch (UserTanlovi)
        {
            case 1:
                while (true)
                {
                        Console.Write("Ismni kiriting: ");
                    var name = Console.ReadLine();
                    var UnderAge = massageUnderAge.Replace(NameToken, $"{name}");
                    var GoldenAge = massageGoldenAger.Replace(NameToken, $"{name}");
                    for (int i = 0; i < name.Length; i++)
                    {
                        var ascii = (int)name[i];
                        if (ascii >= 48 && ascii <= 57)
                        {
                            Console.WriteLine("Invalid name!");
                            break;
                        }
                    }
                    Console.Write("Yoshingizni kiriting: ");
                    int yoshUser = int.Parse(Console.ReadLine());
                    if (yoshUser < 18)
                    {
                        Console.WriteLine(UnderAge);
                        break;
                    }
                    else if (yoshUser > 18 && yoshUser < 90)
                    {
                        ismlar.AddLast(name);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(GoldenAge);
                        break;
                    }
                }
                    break;
            case 2:
                break;
            case 3:
                break;
        }
    }
    else { 
        break;
    }
}