//CarRental class ochamiz
//IsRented property ochamiz ijarada/ijarada emas
//RentStartTime property ochamiz ijaraga olingan vaqt
//BrandName moshina brendi property
//Id Guid moshinaning idsi property

//Bmw - CarRentaldan voris sealed class ochamiz
//Audi - CarRentaldan voris sealed class ochamiz
//ikkisidaham---
//ModelName property ochish
//RentPriceHour soatiga ijara puli property bmw-30 $ audi 20$
//kanstruktorlarida (modelname bolsin)

//CarRentalManagement classi ochish
//Cars kalleksiya CarRental tipida ochish
//Add(car) methodini ochish kalleksiyaga 1 ta moshinani qoshsin
//Rent (brandname) wu brand boyicha moshina topilsa RentStartTimega hozirgi qiymat qoysin
//va IsRented ga true qiymatini bersin va moshina objectini qaytarsin
//aks holda "Uzr, hozirda ijaraga moshina yo'q" yozuvi chiqsin

//RentPriceNumber method ijaraga olgan vaqtdan hozirgacha ijara pulini hisoblovchi method

//return (car) car obj idsi boyicha qidirb, IsRented false bolsin, RentPriceNumber da hisoblab va balancega qoshsin
//CalculateBalance barcha moshinaning balansi hisoblanib ekranga chiqsin\
// kanstruktori default bosin yani Cars kalleksiyaga bow kalleksiya qiymatini bersin



public abstract class CarRental
{
    public bool IsRented { get; set; }
    public DateTime RentStartTime { get; set; }
    public string BrandName { get; set; }
    public Guid Id { get; set; }
    public double Balance = 0;

}

public sealed class Bmw : CarRental
{
    public string ModelName { get; set; }
    public const int RentPriceHour = 30;
    public Bmw(string modelname)
    {
        BrandName = "BMW";
        Id = Guid.NewGuid();
        IsRented = false;
        ModelName = modelname;
    }
}

public sealed class Audi : CarRental
{
    public string ModelName { get; set; }
    public const int RentPriceHour = 20;
    public Audi(string modelname)
    {
        BrandName = "AUDI";

        Id = Guid.NewGuid();
        IsRented = false;
        ModelName = modelname;
    }
}

public class CarREntalManagement
{
    public int balance = 0;
    public List<CarRental> Cars = new List<CarRental>();

    public void Add(CarRental car)
    {
        Cars.Add(car);
    }
    public void Rent(string brandname)
    {
        foreach (var item in Cars)
        {
            if (item.BrandName == brandname)
            {
                item.RentStartTime = DateTime.Now;
                item.IsRented = true;
                item.BrandName = brandname;
            }
            else
            {
                Console.WriteLine("Uzr, hozirda ijaraga moshina yo'q!");
            }
        }
    }

    public void Return(CarRental car)
    {
        foreach (var item in Cars)
        {
            if (car.Id == item.Id)
            {
                item.IsRented = false;
                var seconds = (DateTime.Now - item.RentStartTime).TotalSeconds;
                
                if(car is Bmw)
                {
                    car.Balance += seconds * Bmw.RentPriceHour;
                }
                else
                {
                    car.Balance += seconds * Audi.RentPriceHour;
                }
            }
        }
    }


}
