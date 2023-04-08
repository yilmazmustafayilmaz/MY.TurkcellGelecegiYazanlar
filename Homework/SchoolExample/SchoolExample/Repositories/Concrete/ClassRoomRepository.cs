using SchoolExample.Entities;
using SchoolExample.Repositories.Abstract;
using System.Linq.Expressions;

namespace SchoolExample.Repositories.Concrete;

public class ClassroomRepository : IClassroomRepository
{
    List<Classroom> _classRooms;
    public ClassroomRepository()
    {
        _classRooms = new List<Classroom>()
        {
            new(){ Id = 1, ClassName = "Net Core Sınıfı" },
        };
    }
    public void Add(Classroom entity)
        => _classRooms.Add(entity);

    public List<Classroom> GetAll()
        => _classRooms;

    public Classroom GetByFilter(Expression<Func<Classroom, bool>> filter)
        => _classRooms.AsQueryable().FirstOrDefault();

    public void Remove(int Id)
        => _classRooms.Remove(GetByFilter(x => x.Id == Id));
}
