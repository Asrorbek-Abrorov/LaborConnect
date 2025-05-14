using LaborConnect.Domain.Commons;
using System.Security;

namespace LaborConnect.Domain.Entities.Users;

public class UserRole : Auditable
{
    public string Name { get; set; }
}
