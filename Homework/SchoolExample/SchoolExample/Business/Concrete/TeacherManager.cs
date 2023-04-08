using SchoolExample.Business.Abstract;
using SchoolExample.Business.Constants;
using SchoolExample.Business.Rules;
using SchoolExample.Core.Results;
using SchoolExample.Entities;
using SchoolExample.Repositories.Abstract;
using System.Collections;
using System.Linq.Expressions;

namespace SchoolExample.Business.Concrete;

public class TeacherManager : ITeacherService
{
    ITeacherRepository _teacherRepository;
    BusinessRules<Teacher> _businessRules;
    public TeacherManager(ITeacherRepository teacherRepository)
    {
        _teacherRepository = teacherRepository;
        _businessRules = new BusinessRules<Teacher>(_teacherRepository);
    }
    public IResult Add(Teacher entity)
    {
        _businessRules.ExistsId(entity.Id);
        _teacherRepository.Add(entity);
        return new SuccessResult(message: Messages.Added);
    }

    public IDataResult<List<Teacher>> GetAll()
    {
        return new SuccessDataResult<List<Teacher>>(_teacherRepository.GetAll(), message: Messages.Listed);
    }

    public IDataResult<Teacher> GetByFilter(Expression<Func<Teacher, bool>> filter)
    {
        return new SuccessDataResult<Teacher>(_teacherRepository.GetByFilter(filter), message: Messages.Listed);
    }

    public IResult Remove(int Id)
    {
        _businessRules.NotFound(Id);
        var teacher = _teacherRepository.GetByFilter(x => x.Id == Id);
        _teacherRepository.Remove(teacher.Id);
        return new SuccessResult(message: Messages.Deleted);
    }
}
