using System;
using TappIOS.Services;

namespace TappIOS.Domain.Appointment.Services
{

    public interface IAppoitmentRepository : IGenericViewModel<Appointment>
    {

    }

    public sealed class AppoitmentRepository : GenericRepository<Appointment>, IAppoitmentRepository
    {

    }
}

