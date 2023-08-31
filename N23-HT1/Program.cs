//N23 - HT1 - order by descending, then by descending, take

//- Product modelidan foydalaning ( name, stars, inventory ) -stars - 1 dan 5 gacha rating, inventory - nechta borligi
//- Product tipidagi list yarating va 10 ta product qo'shing
//- uni rating bo'yicha saralang, keyin nechta qolganligi bo'yicha
//- ekranga 5 tasini chiqaring

//example 

using N23_HT1.Models;

var products = new List<Product>
{
    new Product("iPhone 12", 4, 60),
    new Product("Samsung Galaxy S21", 4, 75),
    new Product("Google Pixel 5", 4, 50),
    new Product("OnePlus 9 Pro", 4, 60),
    new Product("Xiaomi Mi 11", 4, 80),
    new Product("Sony Xperia 1 III", 3, 40),
    new Product("LG Wing", 3, 30),
    new Product("Motorola Edge+", 3, 35),
    new Product("Iphone 14", 5, 10),
    new Product("Asus ROG Phone 5", 4, 70)
};

//output

//Iphone 14 - 10 in stock
//Xiaomi Mi 11 - 80 in stock
//Samsung Galaxy S21 - 75 in stock
//Asus ROG Phone 5 - 70 in stock
//iPhone 12 - 60 in stock

var orderByStar = products.OrderByDescending(product => product.Star);
foreach (var product in orderByStar)
    Console.WriteLine($"{product.Name} - {product.Star} - {product.Inventory}");


Console.WriteLine();

var orderByInventory = products.OrderByDescending(product => product.Inventory);
foreach (var product in orderByInventory)
    Console.WriteLine($"{product.Name} - {product.Inventory} in stock!");

