using ShinigLight.ApplicationLogic.Abstractions;
using ShinigLight.ApplicationLogic.DataModels;
using ShinigLight.ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShinigLight.ApplicationLogic.Services
{
    public class ClinicsService
    {
        private IClinicRepository clinicRepository;
        public ClinicsService(IClinicRepository clinicRepository)
        {
            this.clinicRepository = clinicRepository;
        }
        public Clinic GetClinicById(string clinicId)
        {
            Guid clinicGuid = Guid.Empty;
            if (!Guid.TryParse(clinicId, out clinicGuid))
                throw new Exception("Invalid guid format");
            var clinic = clinicRepository.GetClinicById(clinicGuid);
            if (clinic == null)
                throw new EntityNotFoundException(clinicGuid);
            return clinic;
        }
    }
}
