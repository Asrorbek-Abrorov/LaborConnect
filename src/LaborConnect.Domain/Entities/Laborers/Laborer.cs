using LaborConnect.Domain.Commons;
using LaborConnect.Domain.Entities.Users;

namespace LaborConnect.Domain.Entities.Laborers;

public class Laborer : Auditable
{
    public long UserId { get; set; }
    public string Bio { get; set; }
    public string Location { get; set; }
    public int ExperienceYears { get; set; }
    public bool available { get; set; }
    public User User { get; set; }
}