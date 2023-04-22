using System;
using TappIOS.Services;

namespace TappIOS.Domain.Admin.Services
{
    public class AdminRepository : IBridge
    {
        public void GetData()
        {
            Console.WriteLine("Return admin repository data.");
        }
    }
}

