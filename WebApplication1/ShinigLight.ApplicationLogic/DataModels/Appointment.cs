using System;
using System.Collections.Generic;
using System.Text;

namespace ShinigLight.ApplicationLogic.DataModels
{
    public class Appointment
    {
        public Guid ID { get; set; }
        public User User { get; set; }
        public Doctor Doctors { get; set; }

        public string Type { get; set; }
        public decimal Prices { get; set; }
    }
}
