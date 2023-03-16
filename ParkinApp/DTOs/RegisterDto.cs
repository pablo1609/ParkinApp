using System.ComponentModel.DataAnnotations;

namespace ParkinApp.DTOs;

public class RegisterDto
{
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
    public string UserTimeZoneId { get; set; } 
}