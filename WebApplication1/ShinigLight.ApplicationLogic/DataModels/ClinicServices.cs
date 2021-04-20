using System;
using System.Collections.Generic;
using System.Text;

namespace ShinigLight.ApplicationLogic.DataModels
{
    public class ClinicServices
    {
        public Guid ID { get; set; }
        public Guid ServicesID { get; set; }
        public Guid ClinicID { get; set; }
        public Services Services { get; set; }

        public Clinic Clinic { get; set; }
    }
}
