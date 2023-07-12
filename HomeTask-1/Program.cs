// Task-1
Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("Surname: ");
string Surname = Console.ReadLine();

Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

Console.WriteLine($"\nName: {name}\nSurname: {Surname}\nAge: {age}");

//Task-2

DateTime now1 = DateTime.Now;
DateTime date = new DateTime(1970, 1, 1);
byte ageA = 37;
float balance = 45.43F;
string name1 = "Mexrojiddin";

Console.WriteLine(now1);
Console.WriteLine(date);
Console.WriteLine(ageA);
Console.WriteLine(balance);
Console.WriteLine(name1);

//Task-3
//Primitive
bool aLife = true;
int myAge = 19;

Console.WriteLine($"Primitive type: {aLife}, {myAge}");

//complex
DateTime now = DateTime.Now;

Console.WriteLine($"Complex type: {now}");

// value type
char character = '#';
int number = 12_320;

Console.WriteLine($"Value type: {character}, {number}");

//reference type
string carModel = "Ferrari";

Console.WriteLine($"Reference type: {carModel}");