//-online ob havo dasturi tuzing
//- WeatherReport service dan foydalaning
//- unda Get methodi bo'lsin - berilgan sanadan kelib chiqib ob-havoni string formatda qaytarsin
//- unda private Find methodi bo'lsin - agar berilgan kunga ob - havo topilmasa null qaytarsin
//- Get methodida Find methodidan foydalaning agar qaytgan qiymat null bo'lsa - "Berilgan kunga ob-havo topilmadi, boshqa kunlar uchun qidiirb ko'ring" message chiqsin, yo'qsa ob-havoni qaytarsin
//- Add ( sana, ob-havo qisqacha ) methodi qo'shing - u ob-havo kolleksiyaga qo'shib borsin
//- object yaratib, 6 ta ob-havo ma'lumotini qo'shing, 2 tasini ( bitta mavjud va bitta yo'q bo'lgan ) ob - havoni so'rang va ekranga chiqaring

//-ValidatedWeahterReport service dan foydalaning, WeatherReport dan vorislik olgan bo'lsin
//- unda Add methodini override qiling - kiritilgan ob-havo sana bo'yicha yo'qligini tekshiring
//- agar bor bo'lsa, o'sha ob-havoni o'zgartiring, bo'lmasa yangisini qo'shing
//- object yaratib, 6 ta ob-havo ma'lumotini qo'shing ( 2 tasi sanasi bir xil bo'lsin )

//-UltimateWeatherReport service dan foydalaning, ValidatedWeahterReport dan vorislik olgan bo'lsin
//- unda Get methodi bo'lsin - berilgan sana va nechta kunligidan kelib o'sib borish tartibida ob-havo ma'lumotlarini qaytarsin
//- yana bitta Get methodi bo'lsin - unda faqat nechta kun uchun ob-havo kerakligini bildiruvchi paramter bo'lsin - bugundan boshlab shuncha kun uchun ob-havo ma'lumotlarini o'sib borish tartibida qaytarsin
//- o'sib borish tartibida tartiblash uchun Sort nomli private methoddan foydalaning
//- ikkala Get methodida ham agar berilgan nechta kunigi bo'yicha to'liq ma'lumot bo'lmasa "Uzr, to'liq ma'lumot yo'q" ekranga chiqsin va bo'sh kolleksiya qatarilsin
//- object yaratib, 10 ta ob-havo ma'lumoti qo'shing va Get methodlari orqali so'rov qilib, ekranga chiqaring

WeatherReport dastur = new WeatherReport();
dastur.Add(new DateOnly(2023, 8, 3), "Juda ham issiq - 50 gradus!");
dastur.Add(new DateOnly(2023, 8, 4), "Sovuq va ozgina shamol");
dastur.Add(new DateOnly(2023, 8, 1), "O'rtacha");
dastur.Get(new DateOnly(2023, 8, 3));

ValidatedWeahterReport dastur2 = new ValidatedWeahterReport();
dastur2.Add(new DateOnly(2023, 8, 3), "Sovuuuuuq!");

dastur2.Get(new DateOnly(2023, 8, 3));

public class WeatherReport
{
    private string _FindJavobi = null;
    public Dictionary<DateOnly, string> dict = new Dictionary<DateOnly, string>();
    public virtual void Add(DateOnly data, string obhavo)
    {
        dict.Add(data, obhavo);
    }
    
    public void Get(DateOnly sana)
    {
        Find(sana);
        if (_FindJavobi == null)
        {
            Console.WriteLine("Berilgan kunga ob-havo topilmadi, boshqa kunlar uchun qidiirb ko'ring!");
        }
        else
        {
            Console.WriteLine(_FindJavobi);
        }
    }
    private void Find(DateOnly qaytaruvchiSana)
    {
        foreach (var item in dict)
        {
            if (qaytaruvchiSana == item.Key)
            {
                _FindJavobi = item.Value.ToString();
            }
        }
    }
}

public class ValidatedWeahterReport : WeatherReport
{
    public override void Add(DateOnly data, string obhavo)
    {
        var couont = 0;
        foreach (var item in dict)
        {
            if (item.Key == data)
            {
                dict[item.Key] = obhavo;
                couont++;
            }
        }
        if (couont == 0)
        {
            dict.Add(data, obhavo);
        }
    }
}

public class UltimateWeatherReport : ValidatedWeahterReport
{
    private void Sort()
    {
        foreach(var item in dict)
        {
            foreach(var item2 in dict)
            {
                if (item.Key.DayOfYear > item2.Key.DayOfYear)
                {
                    Console.WriteLine($"{item}");
                }
            }
        }
    }
    public void Get(DateOnly data, int berilanKun)
    {
        if (berilanKun <= dict.Count)
        {
            foreach(var item in dict)
            {
                if (item.Key.DayOfYear > data.DayOfYear)
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        } else
        {
            Console.WriteLine("Uzr, to'liq ma'lumot yo'q");
        }
    }

    public void Get(int kiritilganKun)
    {
        if (kiritilganKun < dict.Count)
        {

        } else
        {
            Console.WriteLine("Uzr, to'liq ma'lumot yo'q");
        }
    }
}