using System;
using Unity;
using Unity.ServiceLocation;
using CommonServiceLocator;
using MediatR;
using TappIOS.Domain;
using TappIOS.Domain.User;
using TappIOS.Domain.User.Services;
using TappIOS.Domain.User.ViewModel;

namespace TappIOS.Services
{
	public class DI
	{

		public static UnityContainer Container { get; set; }

		public DI()
		{
		}

		public static void InitDI()
		{
			DI.Container = new UnityContainer();

			DI.Container.RegisterType<IGenericRepository<BaseEntity>, GenericRepository<BaseEntity>>();
            DI.Container.RegisterType<IUserRepository, UserRepository>();

			DI.Container.RegisterType<IGenericViewModel<BaseEntity>, GenericViewModel<BaseEntity>>();
            DI.Container.RegisterType<IUserViewModel, UserViewModel>();

            var serviceLocator = new UnityServiceLocator(DI.Container);
			ServiceLocator.SetLocatorProvider(() => serviceLocator);
		}
	}
}

