using SchoolExample.Business.Abstract;
using SchoolExample.Business.Constants;
using SchoolExample.Business.Rules;
using SchoolExample.Core.Results;
using SchoolExample.Entities;
using SchoolExample.Repositories.Abstract;
using System.Linq.Expressions;

namespace SchoolExample.Business.Concrete;

public class ClassroomManager : IClassroomService
{
    IClassroomRepository _classroomRepository;
    BusinessRules<Classroom> _businessRules;
    public ClassroomManager(IClassroomRepository classroomRepository)
    {
        _classroomRepository = classroomRepository;
        _businessRules = new BusinessRules<Classroom>(_classroomRepository);
    }
    public IResult Add(Classroom entity)
    {
        _businessRules.ExistsId(entity.Id);
        _classroomRepository.Add(entity);
        return new SuccessResult(message: Messages.Added);
    }

    public IDataResult<List<Classroom>> GetAll()
    {
        return new SuccessDataResult<List<Classroom>>(_classroomRepository.GetAll(), message: Messages.Listed);
    }

    public IDataResult<Classroom> GetByFilter(Expression<Func<Classroom, bool>> filter)
    {
        return new SuccessDataResult<Classroom>(_classroomRepository.GetByFilter(filter), message: Messages.Listed);
    }

    public IResult Remove(int Id)
    {
        _businessRules.NotFound(Id);
        var student = _classroomRepository.GetByFilter(x => x.Id == Id);
        _classroomRepository.Remove(student.Id);
        return new SuccessResult(message: Messages.Deleted);
    }
}
