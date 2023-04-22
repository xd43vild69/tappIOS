using System;
using TappIOS.Services;

namespace TappIOS.Domain.Admin.Features
{
    public class AdminGetData : GenericBridge
    {
        public override void GetData()
        {
            Console.WriteLine("Admin Get Data");
        }
    }
}

