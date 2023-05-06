using System;
using TappIOS.Services;
namespace TappIOS.Domain.Appointment.ViewModel
{
    public interface IAppoitmentViewModel : IGenericViewModel<Appointment>
    {
    }

    public class AppoitmentViewModel : GenericViewModel<Appointment>, IAppoitmentViewModel
    {
        public AppoitmentViewModel() { }
        void Create() { }
        void Update() { }
        void Get() { }
        void Notify() { }
    }
}

