using ShinigLight.ApplicationLogic.Abstractions;
using ShinigLight.ApplicationLogic.DataModels;
using ShinigLight.ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShinigLight.ApplicationLogic.Services
{
    public class ClinicsServicesService
    {
        private IClinicServiceRepository clinicserviceRepository;
        public ClinicsServicesService(IClinicServiceRepository clinicserviceRepository)
        {
            this.clinicserviceRepository = clinicserviceRepository;
        }
        public ClinicServices GetClinicServiceById(string clinicserviceId)
        {
            Guid clinicserviceGuid = Guid.Empty;
            if (!Guid.TryParse(clinicserviceId, out clinicserviceGuid))
                throw new Exception("Invalid guid format");
            var clinicservice = clinicserviceRepository.GetServicesByClinicId(clinicserviceGuid);
            if (clinicservice == null)
                throw new EntityNotFoundException(clinicserviceGuid);
            return (ClinicServices)clinicservice;
        }
    }
}
