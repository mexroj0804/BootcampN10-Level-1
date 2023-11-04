
using System;

Console.WriteLine("Kiriting: ");
var zipCode = Console.ReadLine();
var dastur = new Hisob();

var result = dastur.IsValidZipCode(zipCode);

Console.WriteLine(result);

public class Hisob
{
    public ValueTask<bool> IsValidZipCode(string zipCode)
    {
        if (!string.IsNullOrWhiteSpace(zipCode))
        {
            var countCharacter = 0;
            for (int index = 0; index < zipCode.Length; index++)
            {
                if (!char.IsNumber(zipCode[index]))
                    countCharacter++;
            }
            if (countCharacter == 0) return new ValueTask<bool>(true);
            else return new ValueTask<bool>(false);
        }
        return new ValueTask<bool>(false);
    }
}



//for (var index = 0; index < zipCode.Length; index++)
//{
//    if (char.IsLetter(zipCode[index]) || (index > 0
//        && (zipCode[index - 1].ToString().Equals("o", StringComparison.OrdinalIgnoreCase)
//        || zipCode[index - 1].ToString().Equals("g", StringComparison.OrdinalIgnoreCase))
//        && (zipCode[index].ToString().Equals("'") || zipCode[index] == '`')))
//        return false;
//    else return true;
//}