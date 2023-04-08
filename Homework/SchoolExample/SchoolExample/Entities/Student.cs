using SchoolExample.Core.Entities;

namespace SchoolExample.Entities;

public class Student : BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string SchoolNumber { get; set; }
}
