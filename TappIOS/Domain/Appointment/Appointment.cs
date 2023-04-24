using System;
namespace TappIOS.Domain.Appointment
{
	public class Appointment
	{
		public Guid AppointmentId { get; set; }
        public Guid CustomerId { get; set; }
		public DateTime ScheduleDate { get; set; }

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

