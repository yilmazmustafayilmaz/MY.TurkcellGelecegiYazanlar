using SchoolExample.Core.Entities;

namespace SchoolExample.Entities;

public class Teacher : BaseEntity<short>
{
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string Branch { get; set; } = string.Empty;
}
