using System;
using TappIOS.Services;

namespace TappIOS.Domain.User.Services
{
    public class UserRepository2 : IBridge
    {
        public void GetData()
        {
            Console.WriteLine("Return user repository data.");
        }
    }
}

