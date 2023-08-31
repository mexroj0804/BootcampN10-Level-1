using N15_T1.Triangle;
try
{
    Triangle triangle = new Triangle(3, 4, 9);
    Console.WriteLine($"Uchburchak yuzi: {triangle.Area} Perimetri: {triangle.Perimetr}");
} catch (ArgumentException massage)
{
    Console.WriteLine(massage.Message );
}