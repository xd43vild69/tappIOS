using System;
using System.Threading.Tasks;
using TappIOS.Domain.Admin.Services;
using TappIOS.Domain.User.Services;
using TappIOS.Services;

namespace TappIOS.Domain.Admin.VIewModel
{
    public interface IAdminViewModel : IGenericViewModel<Admin>
    {        
    }

    public class AdminViewModel : GenericViewModel<Admin>, IAdminViewModel
    {
        public IAdminRepository AdminRepository { get; set; }
        public AdminViewModel(IAdminRepository adminRepository)
        {
            AdminRepository = adminRepository;
        }
    }
}

