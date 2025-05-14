using LaborConnect.Domain.Commons;

namespace LaborConnect.Domain.Entities.Users;

public class User : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public long RoleId { get; set; }
    public UserRole Role { get; set; }
}