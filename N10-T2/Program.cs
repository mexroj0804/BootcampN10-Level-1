Console.Write("Yoshingizni kiriting: ");
var yosh = int.Parse(Console.ReadLine());
try
{
    var yosh1 = yosh switch
    {
        < 18 => throw new ArgumentOutOfRangeException("Sorrry, you're too young!"),
        > 90 => throw new ArgumentOutOfRangeException("Sorry, you're too old!"),
        > 18 and < 90 => "Valid age"
    };
    Console.WriteLine(yosh1);


} catch (ArgumentOutOfRangeException exception) 
{            Console.WriteLine(exception.Message);
}

