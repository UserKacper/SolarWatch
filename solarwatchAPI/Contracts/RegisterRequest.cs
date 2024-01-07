using System.ComponentModel.DataAnnotations;

namespace solarwatchAPI.Contracts;

public record RegistrationRequest ([Required] string Email, [Required] string Username, [Required] string Password);

public record RegistrationResponse (string Email, string UserName);

