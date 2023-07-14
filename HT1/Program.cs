using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

var harflar = "abcdefjhijklmonqrstuvwxyz";
var raqamlar = "1234567890";
var symvollar = "!@#$%^&*()_?/<>[]{}|";

Console.Write("Passwordda harflar qatnashsinmi? (h/y)");
var harflar1 = Convert.ToChar(Console.ReadLine());

Console.Write("Passwordda sonlar qatnashsinmi? (h/y)");
var raqamlar1 = Convert.ToChar(Console.ReadLine());

Console.Write("Passwordda simvollar qatnashsinmi? (h/y)");
var symvollar1 = Convert.ToChar(Console.ReadLine());

Console.Write("Password uzunligini kiriting: ");
var len = Convert.ToInt32(Console.ReadLine());

Random rd = new Random();

var hammasi = string.Empty;

if (harflar1 == 'h')
{
    hammasi += harflar;
}
if (raqamlar1 == 'h')
{
    hammasi += raqamlar;
}
if (symvollar1 == 'h')
{
    hammasi += symvollar;
}

var password = string.Empty;

if (hammasi.Length == 0)
{
    Console.WriteLine("Siz birortasini tanlamadingiz!");
}
else
{
    for (int i = 0; i < len; i++)
    {
        var next = rd.Next(0, hammasi.Length);
        password += hammasi[next];
    }

    Console.WriteLine($"Sizning passwordingiz: {password}");
}