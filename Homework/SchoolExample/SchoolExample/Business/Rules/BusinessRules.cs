using SchoolExample.Core.Entities;
using SchoolExample.Core.Exceptions;
using SchoolExample.Core.Repositories;

namespace SchoolExample.Business.Rules;

public class BusinessRules<TEntity> : IBusinessRules<TEntity> where TEntity : BaseEntity<short>
{
    IBaseRepository<TEntity> _repository;
    public BusinessRules(IBaseRepository<TEntity> repository)
        => _repository = repository;

    public void NotFound(int Id)
    {
        var result = _repository.GetByFilter(x => x.Id == Id);
        if (result is null) throw new BusinessException("This id is not exists");
    }
    public void ExistsId(int Id)
    {
        var result = _repository.GetByFilter(x => x.Id == Id);
        if (result is not null) throw new BusinessException("This id already exists");
    }
}
