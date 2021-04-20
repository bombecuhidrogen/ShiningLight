using ShinigLight.ApplicationLogic.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShinigLight.ApplicationLogic.Abstractions
{
  
        public interface IClinicServiceRepository : IRepository<ClinicServices>
        {
           IEnumerable<ClinicServices> GetServicesByClinicId(Guid clinicId);
         
        }

}
