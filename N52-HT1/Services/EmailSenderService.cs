using N52_HT1.Interfaces;
using N52_HT1.Models;
using System.Net;
using System.Net.Mail;

namespace N52_HT1.Services
{
    public class EmailSenderService : IEmailSenderService
    {
        public async Task SendEmailAsync(User user)
        {
            var smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");
            smtp.EnableSsl = true;

            var fullName = $"{user.FirstName} {user.LastName}";
            var mail = new MailMessage("sultonbek.rakhimov.recovery@gmail.com", user.EmailAddress);
            mail.Subject = MessageConstants.Subject;
            mail.Body = MessageConstants.Body.Replace("{{FullName}}", fullName);

            await smtp.SendMailAsync(mail);
        }
    }
}
