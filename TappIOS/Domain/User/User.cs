using System;
namespace TappIOS.Domain.User
{
	public class User : BaseEntity
	{
		public User()
		{
		}

        public override void GetData()
        {
            Console.WriteLine("GetData User Entity");
            _bridge.GetData();
        }
    }
}

