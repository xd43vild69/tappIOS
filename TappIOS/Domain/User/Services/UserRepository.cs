using System;
using System.Threading;
using System.Threading.Tasks;
using TappIOS.Services;

namespace TappIOS.Domain.User.Services
{
	public interface IUserRepository : IGenericRepository<User>
	{
		public Task<bool> CheckUserLogin(string name, string password);
	}

    public sealed class UserRepository : GenericRepository<User>, IUserRepository
    {
        public Task<bool> CheckUserLogin(string name, string password)
        {
            throw new NotImplementedException();
        }
    }
}

