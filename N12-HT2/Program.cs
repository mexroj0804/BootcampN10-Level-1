using System.Text.RegularExpressions;
using System.Windows.Markup;
try
{
    Email email1 = new Email
    {
        to = "mexrojhaybullayev@gmail.com",
        From = "olimovmansurjon@gmail.com",
        Subject = "Salomlashish uchun!",
        Content = "Assalomu aleykum!"
    };
} catch (FormatException massage)
{
    Console.WriteLine(massage.Message);
}

try
{

    Email email2 = new Email
    {
        to = "mexrojxaybullayevgmail..com",
        From = "olimovmansurjon@gmail$.com",
        Subject = null,
        Content = null
    };
} catch (FormatException massage)
{
    Console.WriteLine(massage.Message);
}
public class Email
{
    private string _to;
    public string to
    {
        get
        {
            return _to;
        }
            set
        {
            string email = value;
            var emailAddressRegex = new Regex("^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\\.[a-zA-Z0-9]+$");
            if (emailAddressRegex.IsMatch(email) == true)
            {
                _to = value;
            }
            else
            {
            throw new FormatException("Xato email kiritdingiz!");
            }
        }
    }
    private string _from;
    public string From
    {
        get
        {
            return _from;
        }
        set
        {
            string email = value;
            var emailAddressRegex = new Regex("^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\\.[a-zA-Z0-9]+$");
            if (emailAddressRegex.IsMatch(email) == true)
            {
                _from = value;
            }
            else
            {
                throw new FormatException("Xato email kiritdingiz!");
            }
        }
    }

    private string _subject;
    public string Subject
    {
        get
        {
            return _subject;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new FormatException("Bo'sh");
            }
            else
                _subject = value;
        }
    }

    private string _content;
    public string Content
    {
        get
        {
            return _content;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new FormatException("Bo'sh");
            }
            else
                _content = value;
        }
    }
}