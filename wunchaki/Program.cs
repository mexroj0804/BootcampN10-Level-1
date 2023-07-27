using System;

var length = 7;
var letter = "yes";
var digit = "yes";

var letters = "abcdefghijklmnopqrstuvyxwz";
var digits = "1234567890";

Random rd = new Random();
var all = string.Empty;

for  (var i = 0; i <= length; i++)
{
    if (letter == "yes" && digit == "yes")
    {
        all += rd.Next(0, letters.Length);
    }
    if (digit == "yes")
    {
        all += rd.Next(0, digits.Length);
    }
    if (letter == "no" && digit == "no")
    {
        all = " ";
    }
}
Console.WriteLine("Oldin" + all);

var password = string.Empty;
if (all.Length == 0)
{
    Console.WriteLine("Siz birortasini tanlamadingiz!");
}
else
{
    for (int i = 0; i < length; i++)
    {
        var next = rd.Next(0, all.Length);
        password += all[next];
    }

    Console.WriteLine($"Your password is: {password}");
}