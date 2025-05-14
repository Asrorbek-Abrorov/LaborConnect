using LaborConnect.Domain.Commons;

namespace LaborConnect.Domain.Entities.Laborers;

public class LaborerSkill : Auditable
{
    public long LaborerId { get; set; }
    public long SkillId { get; set; }
    public Laborer Laborer { get; set; }
    public Skill Skill { get; set; }
}