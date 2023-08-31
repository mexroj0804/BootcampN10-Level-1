#region tas1
var number1 = 4;
var number2 = 5;
int p, s;

GetArea(number1, number2, out p, out s);

Console.WriteLine(p + "\n" + s);
static void GetArea(int number1, int number2, out int p, out int s)
{
    p = 2 * (number1 + number2);
    s = number1 * number2;
}

#endregion


