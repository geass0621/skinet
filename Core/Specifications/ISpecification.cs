using System;
using System.Linq.Expressions;


namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }

        List<Expression<Func<T, object>>> Includes { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
        int Take { get; } //for Pagination
        int Skip { get; } //for Pagination
        bool IsPagingEnabled { get; } //for Pagination
    }
}