using SchoolExample.Core.Results;
using System.Linq.Expressions;

namespace SchoolExample.Business.Abstract;

public interface IGenericService<TEntity> where TEntity : class
{
    IDataResult<List<TEntity>> GetAll();
    IDataResult<TEntity> GetByFilter(Expression<Func<TEntity, bool>> filter);
    IResult Add(TEntity entity);
    IResult Remove(int Id);
}
