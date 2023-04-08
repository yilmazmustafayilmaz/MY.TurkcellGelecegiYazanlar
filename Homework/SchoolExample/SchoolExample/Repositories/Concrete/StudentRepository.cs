using SchoolExample.Entities;
using SchoolExample.Repositories.Abstract;
using System.Linq.Expressions;

namespace SchoolExample.Repositories.Concrete;

public class StudentRepository : IStudentRepository
{
    List<Student> _students;
    public StudentRepository()
    {
        _students = new List<Student>()
        {
            new(){ Id = 1, Name = "Mustafa", Surname = "Yılmaz", SchoolNumber = "1111"}
        };
    }
    public void Add(Student entity)
        => _students.Add(entity);

    public List<Student> GetAll()
        => _students;

    public Student GetByFilter(Expression<Func<Student, bool>> filter)
        => _students.AsQueryable().FirstOrDefault(filter);

    public void Remove(int Id)
        => _students.Remove(GetByFilter(x => x.Id == Id));
}
