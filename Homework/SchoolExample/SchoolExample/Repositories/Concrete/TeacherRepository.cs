using SchoolExample.Entities;
using SchoolExample.Repositories.Abstract;
using System.Linq.Expressions;

namespace SchoolExample.Repositories.Concrete;

public class TeacherRepository : ITeacherRepository
{
    List<Teacher> _teachers;
    public TeacherRepository()
    {
        _teachers = new List<Teacher>()
        {
            new(){ Id = 1, Name = "Türkay", Surname = "Ürkmez", Branch = "Net Core"}
        };
    }
    public void Add(Teacher entity)
        => _teachers.Add(entity);

    public List<Teacher> GetAll()
        => _teachers;

    public Teacher GetByFilter(Expression<Func<Teacher, bool>> filter)
        => _teachers.AsQueryable().FirstOrDefault(filter);

    public void Remove(int Id)
        => _teachers.Remove(GetByFilter(x => x.Id == Id));
}
