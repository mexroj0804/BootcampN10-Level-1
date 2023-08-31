using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace N29_HT2.Services
{
    internal class EmailService
    {

        public SmtpClient SmtpClientInstance { get; init; }

        public EmailService()
        {
            SmtpClientInstance = new SmtpClient("smtp.gmail.com", 587);
            SmtpClientInstance.Credentials =
                new NetworkCredential("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");
            SmtpClientInstance.EnableSsl = true;
        }

        public Task<bool> SendAsync(string receiverEmailAddress, string subject, string body, string fullname)
        {
            return Task.Run(async () =>
            {
                var result = true;
                try
                {
                    var smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.Credentials = new NetworkCredential("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");
                    smtp.EnableSsl = true;

                    var mail = new MailMessage("sultonbek.rakhimov@gmail.com", receiverEmailAddress);
                    mail.Subject = subject;
                    mail.Body = body.Replace("{{Employee}}", fullname);

                    await smtp.SendMailAsync(mail);
                }
                catch (Exception e)
                {
                    result = false;
                }

                return result;
            });
        }
    }
}
