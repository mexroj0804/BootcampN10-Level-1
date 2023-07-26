string[] str = new string[5]
{
    "Inception",
    "Dark Knight",
    "Top Gun 2",
    "Don't Look Up",
    "Top Gun"
};

for (int i = 0; i < str.Length; i++)
{
    for (int j = 0; j < str.Length; j++)
    {
        Console.WriteLine(str[i] + str[j]);
    }
}

//foreach(var item in str)
//    Console.WriteLine(item);