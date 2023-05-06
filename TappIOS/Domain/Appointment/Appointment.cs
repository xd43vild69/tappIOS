using System;
using TappIOS.Services.Enums;

namespace TappIOS.Domain.Appointment
{
	public class Appointment
	{
        
		public Guid AppointmentId { get; set; }
        public Guid CustomerId { get; set; }
		public DateTime ScheduleDate { get; set; }
        public decimal Size {get; set;}
        public LocationTatttoo Locacation { get; set; }
        public string Description { get; set; } //TODO: validation # characters
        public string References { get; set; }

        public Appointment()
		{
		}

        void Create() { }
        void Update() { }
        void Get() { }
        void Notify() { }
        void Close() { }
    }
}

