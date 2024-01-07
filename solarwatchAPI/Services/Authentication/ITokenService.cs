using Microsoft.AspNetCore.Identity;

namespace solarwatchAPI.Services.Authentication;

public interface ITokenService
{
    public string CreateToken (IdentityUser user);
}