using N52_HT1.Models;

namespace N52_HT1.Interfaces
{
    public interface IEmailSenderService
    {
        Task SendEmailAsync(User user);
    }
}
