using SchoolExample.Core.Entities;

namespace SchoolExample.Entities;

public class Teacher : BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Branch { get; set; }
}
