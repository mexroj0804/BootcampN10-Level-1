using N63_HT1.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace N63_HT1.Interfaces;

public interface ITokenGeneratorService
{
    string GetToken(User user);
    JwtSecurityToken GetJwtToken(User user);
    List<Claim> GetClaims(User user);
}
