using System;
using TappIOS.Services;

namespace TappIOS.Domain
{
	public abstract class BaseEntity
	{
        public Guid Id { get; private set; } = Guid.NewGuid();

    }
}

