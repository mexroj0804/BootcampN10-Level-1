var ball = 100;
var letter = "lorem ipsum dolor sit amet consectetur adipisicing elit. quaerat est quas commodi quibusdam " +
    "labore, nihil doloribus quam temporibus inventore optio expedita consectetur voluptatem QUIDEM nulla soluta " +
    "earum. Numquam rem alias minima culpa iste distinctio. Eum similique est consequuntur minus, odio nisi recusandae" +
    " iure asperiores facere, reiciendis voluptate maiores! Repellat, dolorum!";

var lst = letter.Split(' ', '.', '!', '?', ',');
var gaplar = letter.Split('.', '?', '!');
int capital = lst[0][0];

//umumiy so'zlar 500 dan kamligini tekshiradi
if (lst.Length < 500)
{
    ball -= 5;
}

//boshidagi so'zning capitalligini tekshiradi
if (capital <= 65 || capital >= 90)
{
    ball -= 5;
}

//gapda 1-chi so'zdan tashqari boshqa so'zlar bosh harf bn boshlanmaganligini tekshiradi
for (int i = 0; i < gaplar.Length; i++)
{
    var sozlar = gaplar[i].Trim().Split(' ');
    for (int j = 0; j < sozlar.Length - 1; j++)
    {
        int sozBoshHarfi = sozlar[j][0];
       
        if ( j != 0 & sozBoshHarfi >= 65 & sozBoshHarfi <= 90)
        {
            ball -= 10;
        }
    }
    if (gaplar.Length > 20)
    {
        ball -= 20;
    }
}

Console.WriteLine(ball);
