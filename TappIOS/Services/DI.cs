using System;
using Unity;
using Unity.ServiceLocation;
using CommonServiceLocator;
using MediatR;
using TappIOS.Domain;
using TappIOS.Domain.User;
using TappIOS.Domain.User.Services;
using TappIOS.Domain.User.ViewModel;
using TappIOS.Domain.Customer.VIewModel;
using TappIOS.Domain.Customer.Services;
using TappIOS.Domain.Appointment.ViewModel;
using TappIOS.Domain.Appointment.Services;

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

			
			DI.Container.RegisterType<IGenericViewModel<BaseEntity>, GenericViewModel<BaseEntity>>();
            DI.Container.RegisterType<IGenericRepository<BaseEntity>, GenericRepository<BaseEntity>>();

            DI.Container.RegisterType<IUserViewModel, UserViewModel>();
            DI.Container.RegisterType<IUserRepository, UserRepository>();

            DI.Container.RegisterType<ICustomerViewModel, CustomerViewModel>();
            DI.Container.RegisterType<ICustomerRepository, CustomerRepository>();

            DI.Container.RegisterType<IAppoitmentViewModel, AppoitmentViewModel>();
            DI.Container.RegisterType<IAppoitmentRepository, AppoitmentRepository>();

            var serviceLocator = new UnityServiceLocator(DI.Container);
			ServiceLocator.SetLocatorProvider(() => serviceLocator);
		}
	}
}

