using System;
namespace TappIOS.Services
{
	public abstract class GenericBridge
	{
		public IBridge _bridge;

		public abstract void GetData();

		public GenericBridge()
		{
		}
	}
}

