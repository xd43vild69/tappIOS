using System;
using System.Threading.Tasks;
using TappIOS.Services;

namespace TappIOS.Domain.Admin.Services
{

    public interface IAdminRepository : IGenericViewModel<Admin>
    {
        
    }

    public sealed class AdminRepository : GenericRepository<Admin>, IAdminRepository
    {

    }
}

