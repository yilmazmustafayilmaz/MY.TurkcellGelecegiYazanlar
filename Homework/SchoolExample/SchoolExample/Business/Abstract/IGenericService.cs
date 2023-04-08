using SchoolExample.Core.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExample.Business.Abstract;

public interface IGenericService<TEntity> where TEntity : class
{
    IDataResult<List<TEntity>> GetAll();
    IDataResult<TEntity> GetByFilter(Expression<Func<TEntity, bool>> filter);
    IResult Add(TEntity entity);
    IResult Remove(int Id);
}
