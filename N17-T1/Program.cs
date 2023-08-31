
EmailtemplateService dastur = new EmailtemplateService();
dastur.Add("Account Registration", "Hurmatli {{User}}, ushbu xabar sizni muvafaqqiyatli ro'yxatdan o'tganligingizni bildirish uchun yuborildi");
dastur.GetRegistrationTemplate("Mexroj");
dastur.GetAccountBlockedTemplates("Jasurbek");

public static class MessageConstants
{
    public const string UserToken = "{{User}}";
}

public class EmailTemplate
{
    public string Subject { get; set; }
    public string Content { get; set; }

    public EmailTemplate(string subject, string content)
    {
        Subject = subject;
        Content = content;
    }
}

public class EmailtemplateService
{
    private List<EmailTemplate> Templates = new List<EmailTemplate>();

    public void Add(string subject, string content)
    {
        Templates.Add(new EmailTemplate(subject, content));
    }

    public void GetRegistrationTemplate(string username)
    {
        foreach (var template in Templates)
        {
            if (template.Subject == "Account Registration")
                Console.WriteLine(template.Content.Replace(MessageConstants.UserToken, username));
        }

    }

    public void GetAccountBlockedTemplates(string username)
    {
        foreach (var template in Templates)
        {
            if (template.Subject == "Account Blocked")
                Console.WriteLine(template.Content.Replace(MessageConstants.UserToken, username));
        }
    }
}