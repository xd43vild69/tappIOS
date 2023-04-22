using System;
using System.Net.Http;
using Intents;
using System.Threading.Tasks;

namespace TappIOS.Services
{
	public class ApiRepository
	{
		public ApiRepository()
		{
		}
        public async Task Connect()
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
        }
    }
}

