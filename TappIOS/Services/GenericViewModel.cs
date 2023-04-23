using System;
using System.Linq;
using TappIOS.Domain;

namespace TappIOS.Services
{
	public interface IGenericViewModel<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> Query();
    }
	public class GenericViewModel<TEntity> : IGenericViewModel<TEntity>
        where TEntity : BaseEntity
    {
        public IQueryable<TEntity> Query()
        {
            throw new NotImplementedException();
        }
    }
}

