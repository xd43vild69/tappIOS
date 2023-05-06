using System;
using System.Threading.Tasks;
using TappIOS.Domain.Customer.Services;
using TappIOS.Domain.User.Services;
using TappIOS.Services;

namespace TappIOS.Domain.Customer.VIewModel
{
    public interface ICustomerViewModel : IGenericViewModel<Customer>
    {
    }

    public class CustomerViewModel : GenericViewModel<Customer>, ICustomerViewModel
    {
        public ICustomerRepository CustomerRepository { get; set; }
        public Customer Customer { get; set; }

        public CustomerViewModel(ICustomerRepository customerRepository)
        {
            CustomerRepository = customerRepository;
        }

        public void Create(BaseEntity baseEntity)
        {
            var customer = baseEntity;
            CustomerRepository.Add(Customer);

        }
        
        void Update() { }
        void Get() { }

        void CreateAppointment() { }
        void UpdateAppointment() { }
        void GetAppointment() { }
    }
}

