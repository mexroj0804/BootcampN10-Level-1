
// shart
//using System.Xml.Linq;
//using System;
//N12 - T1

//- Car modelidan foydalaning(name, brand )
//-Car tipidagi kolleksiyaga 10 ta Car tipidagi object qo'shing ( bir nechtasi bir xil bo'lsin )
//-Kolleksiyada har bitta car dan nechta bir xil object borligini ekranga chiqaring

//Example : 

//"Accord", "Honda"
//"Camry", "Toyota"
//"Civic", "Honda"
//"Accord", "Honda"
//"Elantra", "Hyundai"
//"Accord", "Honda"
//"Sonata", "Hyundai"
//"Elantra", "Hyundai"
//"Fusion", "Ford"
//"Malibu", "Chevrolet"


//Output:

//Accord Honda -3
//Elantra Hyundai - 2

// logika
// car tipini yaratingn ( name, brand )
// car tipidagi list ga 10 ta car qo'shish
// 
// 


List<Car> cars = new List<Car>();
cars.Add(new Car());
public class Car
{
    public string Name;
    public string Brand;

}

