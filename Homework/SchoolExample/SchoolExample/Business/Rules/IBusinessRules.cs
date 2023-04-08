namespace SchoolExample.Business.Rules;

public interface IBusinessRules<TEntity> where TEntity : class
{
    void NotFound(int Id);
    void ExistsId(int Id);
}
