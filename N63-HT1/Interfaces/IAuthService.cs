using N63_HT1.DTOs;

namespace N63_HT1.Interfaces
{
    public interface IAuthService
    {
        ValueTask<bool> RegisterAsync(RegistrationDetails registrationDetails);
        ValueTask<string> LoginAsync(LoginDetails loginDetails);
    }
}
