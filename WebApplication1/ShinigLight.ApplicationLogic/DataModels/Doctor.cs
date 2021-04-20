using System;
using System.Collections.Generic;
using System.Text;

namespace ShinigLight.ApplicationLogic.DataModels
{
    public class Doctor
    {
        public Guid ID { get; set; }
        public Clinic Clinic { get; set; }
        public string Name { get; set; }
        public string Qualification { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
