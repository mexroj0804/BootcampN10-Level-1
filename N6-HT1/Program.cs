var students = new string[]
{
    "Akbar", "Mexroj", "Boburjon", "Asilbek", "Azizbek",
    "Avazbek", "Shohjahon", "Husanboy", "Alisher", "Suxrob"
};

var balls = new int[]
{
    58, 93, 27, 73, 88,
    99, 83, 81, 76, 49
};

var goodStudentlarSoni = 0;
var topStudentlarSoni = 0;

for  (int i = 0; i < balls.Length; i++)
{
    if (balls[i] > 80 && balls[i] < 90)
        goodStudentlarSoni += 1;
    else if (balls[i] > 90)
        topStudentlarSoni += 1;

    for (int j = 0; j < balls.Length; j++)
    {
        if (balls[i] > balls[j])
        {
            var ismAlmashtirishUchun = students[i];
            var sonAlmashtirishUchun = balls[i];

            balls[i] = balls[j];
            balls[j] = sonAlmashtirishUchun;

            students[i] = students[j];
            students[j] = ismAlmashtirishUchun;
        }
    }
}

for (int i = 0; i < balls.Length; i++)
{
    if (balls[i] > 90)
        Console.WriteLine($"{students[i]} - Top");
    else if (balls[i] > 80 && balls[i] < 90)
        Console.WriteLine($"{students[i]} - Good");
    else if (balls[i] < 70)
        Console.WriteLine($"{students[i]} - Fail");
}


Console.WriteLine($"Eng baland ball: {balls[0]}");
Console.WriteLine($"O'rtacha ball: {balls.Sum() / balls.Length}");
Console.WriteLine($"Eng past ball: {balls[balls.Length - 1]}");
Console.WriteLine($"80 dan yuqori ball olgan o'quvchilar soni: {goodStudentlarSoni}");
Console.WriteLine($"90 dan yuqori ball olgan o'quvchilar soni: {topStudentlarSoni}");
