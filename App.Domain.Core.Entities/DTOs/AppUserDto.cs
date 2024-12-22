namespace App.Domain.Core.DTOs;

public class AppUserDto
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public int? BoothId { get; set; }
}