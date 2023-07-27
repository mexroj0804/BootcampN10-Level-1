

PasswordGenerate dastur = new PasswordGenerate(6, "yes", "yes");
dastur.Generate();

PasswordGenerate dastur2 = new PasswordGenerate(6, "yes");
dastur2.Generate();

PasswordGenerate dastur3 = new PasswordGenerate(6, "no", "no");
dastur3.Generate();

SecurePasswordGenerator dastur4 = new SecurePasswordGenerator(6, "yes", "yes");
dastur4.Generate("yes");

UniquePasswordGenerate dastur5 = new UniquePasswordGenerate(6, "yes", "yes");
dastur5.Generate();
public class PasswordGenerate
{
    public int Length {  get; set; }
    public string HasLetters { get; set; }
    public string HasDigits { get; set; }
    public string Passwords;

    public PasswordGenerate(int length, string hasLetter, string hasDigits = "")
    {
        Length = length;
        HasLetters = hasLetter;
        HasDigits = hasDigits;
    }

    public void Generate()
    {
        var length = Length;
        var letter = HasLetters;
        var digit = HasDigits;

        var letters = "abcdefghijklmnopqrstuvyxwz";
        var digits = "1234567890";

        Random rd = new Random();
        var all = string.Empty;

        for (var i = 0; i <= length; i++)
        {
            if (letter == "yes")
            {
                all += letters;
            }
            if (digit == "yes")
            {
                all += digits;
            }
            if (letter == "no" && digit == "no")
            {
                all = "No password!";
                break;
            }
        }
        if (all != "No password!")
        {
            var password = string.Empty;
            for (int i = 0; i < length; i++)
            {
                var next = rd.Next(0, all.Length);
                password += all[next];
            }
            Passwords = password;
            Console.WriteLine($"Your password is: {password}");
        }
        else
        {
            Console.WriteLine(all);
        }
    }
}
public class SecurePasswordGenerator : PasswordGenerate
{
    public SecurePasswordGenerator(int length, string hasLetters, string hasDigits = "")
        : base(length, hasLetters, hasDigits)
    {
    }
    public void Generate(string hasSymvols)
    {

        var length = Length;
        var letter = HasLetters;
        var digit = HasDigits;
        var symvol = hasSymvols;

        var letters = "abcdefghijklmnopqrstuvyxwz";
        var digits = "1234567890";
        var Symvols = "!@#$%^&*()?|/";

        Random rd = new Random();
        var all = string.Empty;

        for (var i = 0; i <= length; i++)
        {
            if (letter == "yes")
            {
                all += letters;
            }
            if (digit == "yes")
            {
                all += digits;
            }
            if (symvol == "yes")
            {
                all += Symvols;
            }
            if (letter == "no" && digit == "no")
            {
                all = "No password!";
                break;
            }
        }
        if (all != "No password!")
        {
            var password = string.Empty;
            for (int i = 0; i < length; i++)
            {
                var next = rd.Next(0, all.Length);
                password += all[next];
            }
            Console.WriteLine($"Your password is: {password}");
            Passwords = password;
        }
        else
        {
            Console.WriteLine(all);
        }
    }

}

public class UniquePasswordGenerate : SecurePasswordGenerator
{
    public UniquePasswordGenerate(int length, string hasLetters, string hasDigits = " ")
        : base(length, hasLetters, hasDigits)
    {
        lst.Add(Passwords);
    }
    List<string> lst = new List<string>();
    public void GenerateUniqePassword()
    {
        foreach (var letter in lst)
        {
            if (letter == Passwords)
            {
                Generate();
            }
            else lst.Add(letter);
        }

    }
}
