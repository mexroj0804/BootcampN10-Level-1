var sanalar = new DateOnly[]
{
    new DateOnly(2023, 8, 8),
    new DateOnly(2023, 8, 13),
    new DateOnly(2023, 8, 27),
};

var davomiyligi = new TimeSpan[]
{
    new TimeSpan(9, 0, 0),
    new TimeSpan(10, 0, 0),
    new TimeSpan(13, 0, 0),
};

var bolinishlarSoni = new float[]
{
    2, 0, 1
};

var score = 0f;

for  (var i = 0; i < bolinishlarSoni.Length; i++)
{
    score = (davomiyligi[i].Hours - bolinishlarSoni[i]) / (8 + 0) * 10;
    Console.WriteLine(score);
}