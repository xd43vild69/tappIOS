using System;
namespace TappIOS.Domain.Admin
{
	public class Admin : BaseEntity
	{
		public Admin()
		{
		}

        public override void GetData()
        {
            Console.WriteLine("GetData Admin Entity");
            _bridge.GetData();
        }
    }
}

