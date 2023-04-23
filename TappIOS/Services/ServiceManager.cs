using System;
using System.Threading.Tasks;
using CommonServiceLocator;
using GameplayKit;
using TappIOS.Domain;
using TappIOS.Domain.User;
using TappIOS.Domain.User.Services;
using TappIOS.Domain.User.ViewModel;

namespace TappIOS.Services
{
	public class ServiceManager
	{
        public static IGenericRepository<BaseEntity> _genericRepository { get; }
        public static IUserViewModel _userViewModel { get; }

        static ServiceManager()
        {
            _userViewModel = ServiceLocator.Current.GetInstance<IUserViewModel>();
            _genericRepository = ServiceLocator.Current.GetInstance<IGenericRepository<BaseEntity>>();
        }

        public static async Task<bool> Login(string user, string password)
        {
            var x = await _genericRepository.Exists(Guid.NewGuid());
            return true;
        }

        public static void GetUserSettings(Guid user)
        {
            // TODO: singleton to read user settings
        }

    }
}

