using System;
using System.Collections.Generic;
using System.Text;

namespace ShinigLight.ApplicationLogic.DataModels
{
    public class User
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}
