using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TappIOS.Services;

namespace TappIOS.Domain.User.Services
{
	public interface IUserRepository : IGenericRepository<User>
	{
		Task<bool> CheckUserLogin(string name, string password);
	}

    public sealed class UserRepository : GenericRepository<User>, IUserRepository
    {
        public async Task<bool> CheckUserLogin(string name, string password)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://rickandmortyapi.com/api/character"))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var apiResponse = await response.Content.ReadAsStringAsync();
                        //reservation = JsonConvert.DeserializeObject<Reservation>(apiResponse);
                    }
                    else
                    {
                        var status = response.StatusCode;
                    }
                }
            }
            return true;
        }
    }
}

