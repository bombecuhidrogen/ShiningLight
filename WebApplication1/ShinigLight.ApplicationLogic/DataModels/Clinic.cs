using System;
using System.Collections.Generic;
using System.Text;

namespace ShinigLight.ApplicationLogic.DataModels
{
    public class Clinic
    {
        public Guid ID { get; set; }
        public Appointment Appointment { get; set; }
        public string Address { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<ClinicServices> Client_Services { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
