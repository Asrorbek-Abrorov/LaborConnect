using LaborConnect.Domain.Commons;

namespace LaborConnect.Domain;

public class Skill : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
}