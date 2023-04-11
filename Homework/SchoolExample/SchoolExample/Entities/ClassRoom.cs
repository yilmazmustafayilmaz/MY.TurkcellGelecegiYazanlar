using SchoolExample.Core.Entities;

namespace SchoolExample.Entities;

public class Classroom : BaseEntity<short>
{
    public string ClassName { get; set; } = string.Empty;
}
