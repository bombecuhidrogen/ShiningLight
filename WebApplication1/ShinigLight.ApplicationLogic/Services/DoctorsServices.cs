using ShinigLight.ApplicationLogic.Abstractions;
using ShinigLight.ApplicationLogic.DataModels;
using ShinigLight.ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShinigLight.ApplicationLogic.Services
{
    public class DoctorsService
    {
        private IDoctorsRepository doctorRepository;
        public DoctorsService(IDoctorsRepository doctorRepository)
        {
            this.doctorRepository = doctorRepository;
        }
        public Doctor GetDoctorById(string doctorId)
        {
            Guid doctorGuid = Guid.Empty;
            if (!Guid.TryParse(doctorId, out doctorGuid))
                throw new Exception("Invalid guid format");
            var doctor = doctorRepository.GetDoctorById(doctorGuid);
            if (doctor == null)
                throw new EntityNotFoundException(doctorGuid);
            return doctor;
        }
    }
}
