using SchoolExample.Core.Entities;
using System.Linq.Expressions;

namespace SchoolExample.Core.Repositories;

public interface IBaseRepository<TEntity> where TEntity : BaseEntity
{
    List<TEntity> GetAll();
    TEntity GetByFilter(Expression<Func<TEntity, bool>> filter);
    void Add(TEntity entity);
    void Remove(int Id);
}
