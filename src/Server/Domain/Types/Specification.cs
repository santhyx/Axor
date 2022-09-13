using System.Linq.Expressions;

namespace Domain.Types
{
    internal abstract class Specification<TEntity> where TEntity : Entity
    {
        public Expression<Func<TEntity, bool>> SpecificationExpression { get; protected set; }

        public abstract void DefineSpecification();

        public bool IsSatisfied(TEntity entity) => SpecificationExpression.Compile().Invoke(entity); 
       
        protected Expression<Func<TEntity, bool>> And(Expression<Func<TEntity, bool>> anotherExpression)
        {
            var andExpression = Expression.AndAlso(SpecificationExpression, anotherExpression);

            return Expression.Lambda<Func<TEntity, bool>>(andExpression);
        }

        protected Expression<Func<TEntity, bool>> Or(Expression<Func<TEntity, bool>> anotherExpression)
        {
            var orExpression = Expression.OrElse(SpecificationExpression, anotherExpression);

            return Expression.Lambda<Func<TEntity, bool>>(orExpression);
        }

        protected Expression<Func<TEntity, bool>> Not()
        {
            var notExpression = Expression.Negate(SpecificationExpression);

            return Expression.Lambda<Func<TEntity, bool>>(notExpression);
        }
    }
}
