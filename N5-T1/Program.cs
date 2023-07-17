string application = "{ApplicationDate} {ApplicationNumber} {OrganizationName} rektori { Rektor} ga Abituriyent " +
    "{StudentName} dan. ARIZA Men joriy yilda {OrganizationName}ning " +
    "{EduSpeciality} ta 'lim yo'nalishini {EduForm} ta 'lim shakli, {EduLanguage} ta'lim tili " +
    "bo'yicha ${OrderId} - OTM sifatida tanlab, davlat test sinovida ishtirok etdim.Davlat test markazi " +
    "tomonidan e'lon qilingan test natijasiga ko'ra ${Ball} ball to'pladim va to'lov-kontrakt asosidagi " +
    "qabul chegarasiga ${DifferenceBall} ball yetmay qoldi .Shu munosabat bilan, meni qo'shimcha tarzda " +
    "${EduContractSumType} tabaqalashtirilgan to'lov-kontrakt asosida talabalikka qabul qilishingizni " +
    "hamda menga to`lov shartnomasini taqdim etishingizni so'rayman.Men Oliy ta'lim muassasasining ichki " +
    "tartib qoidalari va kontraktni barcha shartlari bilan tanishib chiqdim hamda tasdiqlangan o'quv rejasi " +
    "bo'yicha belgilangan vaqtlarda darslarga qatnashishga, belgilangan muddatlarda to'lov-kontrakt pulini " +
    "to'lashga va to'lov hujjatlarini topshirishga shaxsan o`zim mas'ulligimni tasdiqlayman.Abituriyent: " +
    "${ Abiturient}ID raqami: ${ AbiturientId}";

Console.WriteLine("Arizani to'ldiring!");
Console.Write("O'qish joyingizni kiriting: ");
var organizeName = Console.ReadLine();

Console.Write("Rektor nomini yozing: ");
var rektor = Console.ReadLine();

Console.Write("Ism va familyezni kiriting: ");
var fn = Console.ReadLine();

Console.Write("Yo'nalishingizni kiriting: ");
var fakultet = Console.ReadLine();

Console.Write("Ta'lim shaklini kiriting: ");
var Tshakl = Console.ReadLine();

Console.Write("Ta'lim tilini kiriting: ");
var language = Console.ReadLine();

DateTime dt  = DateTime.Now;
Guid guid = Guid.NewGuid();

var sana = "{ApplicationDate}";
var guid1 = "{ApplicationNumber}";
var organize = "{OrganizationName}";
var rek = "{ Rektor}";
var full_name = "{StudentName}";
var fakultet1 = "{EduSpeciality}";
var shakl = "{EduForm}";
var til = "{EduLanguage}";

var letter = application
    .Replace(sana, $"{dt}")
    .Replace(guid1, $"{guid}")
    .Replace(organize, $"{organizeName}")
    .Replace(rek, $"{rektor}")
    .Replace(full_name, $"{fn}")
    .Replace(fakultet1, $"{fakultet}")
    .Replace(shakl, $"{Tshakl}")
    .Replace(til, $"{language}");

Console.WriteLine(letter);