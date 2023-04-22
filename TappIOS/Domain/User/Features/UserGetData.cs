using System;
using TappIOS.Services;

namespace TappIOS.Domain.User.Features
{
	public class UserGetData: GenericBridge
	{
        public override void GetData()
        {
            Console.WriteLine("User Get Data");
        }
    }
}

