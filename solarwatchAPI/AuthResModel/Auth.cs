namespace solarwatchAPI.AuthResModel
{
    public record AuthRequest (string Email, string Password);
    public record AuthResponse (string Email, string UserName, string Token);

}
