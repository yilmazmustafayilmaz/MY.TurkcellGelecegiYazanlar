using SchoolExample.Business.Abstract;
using SchoolExample.Business.Constants;
using SchoolExample.Business.Rules;
using SchoolExample.Core.Repositories;
using SchoolExample.Core.Results;
using SchoolExample.Entities;
using SchoolExample.Repositories.Abstract;
using System.Linq.Expressions;

namespace SchoolExample.Business.Concrete;

public class StudentManager : IStudentService
{
    IStudentRepository _studentRepository;
    BusinessRules<Student> _businessRules;
    public StudentManager(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
        _businessRules = new BusinessRules<Student>(_studentRepository);
    }
    public IResult Add(Student entity)
    {
        _businessRules.ExistsId(entity.Id);
        _studentRepository.Add(entity);
        return new SuccessResult(message: Messages.Added);
    }

    public IDataResult<List<Student>> GetAll()
    {
        return new SuccessDataResult<List<Student>>(_studentRepository.GetAll(), message: Messages.Listed);
    }

    public IDataResult<Student> GetByFilter(Expression<Func<Student, bool>> filter)
    {
        return new SuccessDataResult<Student>(_studentRepository.GetByFilter(filter), message: Messages.Listed);
    }

    public IResult Remove(int Id)
    {
        _businessRules.NotFound(Id);
        var student = _studentRepository.GetByFilter(x => x.Id == Id);
        _studentRepository.Remove(student.Id);
        return new SuccessResult(message: Messages.Deleted);
    }
}
