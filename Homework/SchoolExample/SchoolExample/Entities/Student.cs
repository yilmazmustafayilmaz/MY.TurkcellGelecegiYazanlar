using SchoolExample.Core.Entities;

namespace SchoolExample.Entities;

public class Student : BaseEntity<short>
{
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string SchoolNumber { get; set; } = string.Empty;
}
