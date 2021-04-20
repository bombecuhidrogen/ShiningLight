using System;
using System.Collections.Generic;
using System.Text;

namespace ShinigLight.ApplicationLogic.DataModels
{
    public class Services
    {
        public Guid ID { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public ICollection<ClinicServices> ClientServices { get; set; }
    }
}
