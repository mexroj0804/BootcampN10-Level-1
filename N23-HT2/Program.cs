//User modelidan foydalaning ( first name, last name, email address ) 
//-User tipidagi modeldan list yaratib 10 ta user qo'shing
//- foydalanuvchidan qidirish uchun biror narsa yozishni so'rang
//- user lar ichidan shu so'z qatnashganlarini ekranga chiqaring

//Example : 

using N23_HT2.Models;

var users = new List<User>
{
    new User("John", "Doe", "johndoe@example.com"),
    new User("Jane", "Doe", "janedoe@example.com"),
    new User("Bob", "Smith", "bobsmith@example.com"),
    new User("Alice", "Johnson", "alicejohnson@example.com"),
    new User("Mike", "Brown", "mikebrown@example.com"),
    new User("Emily", "Davis", "emilydavis@example.com"),
    new User("David", "Wilson", "davidwilson@example.com"),
    new User("Sarah", "Taylor", "sarahtaylor@example.com"),
    new User("Tom", "Anderson", "tomanderson@example.com"),
    new User("Lisa", "Thomas", "lisathomas@example.com")
};


Console.Write("Userlarni qidirish uchun so'z kiriting: ");
var keyWoard = Console.ReadLine();

var result = users.Where(user => user.FirstName.ToLower().Contains(keyWoard.ToLower())
|| user.LastName.ToLower().Contains(keyWoard.ToLower())
|| user.EmailAdress.ToLower().Contains(keyWoard.ToLower()));

result.ToList().ForEach(user => Console.WriteLine($"{user.FirstName} {user.LastName} - {user.EmailAdress}"));

//keyword - li

//output

//Alice Johnson - alicejohnson@example.com
//Lisa Thomas - lisathomas@example.com
