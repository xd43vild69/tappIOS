using System;
using System.Collections.Generic;
using TappIOS.Domain.Appointment;

namespace TappIOS.Domain.Customer
{
	public class Customer : BaseEntity
	{
        public string Name { get; set; }
        public string Cellphone { get; set; }
        public string Email { get; set; } // Add validation-Regex email on set
        public string InstagramUser { get; set; }
        public List<Appointment.Appointment> Appointments { get; set; }
     
        public Customer()
		{
		}

        void Create() { }
        void Update() { }
        void Get() { }

        void CreateAppointment() { }
        void UpdateAppointment() { }
        void GetAppointment() { }

    }
}

