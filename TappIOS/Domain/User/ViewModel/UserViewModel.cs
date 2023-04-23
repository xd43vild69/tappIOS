using System;
using System.Linq;
using System.Threading.Tasks;
using TappIOS.Domain.User.Services;
using TappIOS.Services;

namespace TappIOS.Domain.User.ViewModel
{
    public interface IUserViewModel : IGenericViewModel<User>
    {
        public Task<bool> CheckUserLogin(string name, string password);
    }

    public class UserViewModel: GenericViewModel<User>, IUserViewModel
	{
		public IUserRepository UserRepository { get; set; }
		public UserViewModel(IUserRepository userRepository)
		{
			UserRepository = userRepository;
		}

		public async Task<bool> CheckUserLogin(string name, string password)
		{
			return await UserRepository.CheckUserLogin(name, password);
		}

    }
}

