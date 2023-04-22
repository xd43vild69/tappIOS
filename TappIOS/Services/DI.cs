using System;
using Unity;
using Unity.ServiceLocation;
using CommonServiceLocator;
using MediatR;
using TappIOS.Domain;

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
			//DI.Container.RegisterType<IGenericRepository<BaseEntity>, GenericRepository<BaseEntity>>();

			var serviceLocator = new UnityServiceLocator(DI.Container);
			ServiceLocator.SetLocatorProvider(() => serviceLocator);
		}
	}
}

