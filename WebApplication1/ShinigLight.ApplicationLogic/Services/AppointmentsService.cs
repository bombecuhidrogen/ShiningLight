using ShinigLight.ApplicationLogic.Abstractions;
using ShinigLight.ApplicationLogic.DataModels;
using ShinigLight.ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShinigLight.ApplicationLogic.Services
{
    public class AppointmentsService
    {
        private IAppointmentRepository appointmentRepository;
        public AppointmentsService(IAppointmentRepository appointmentRepository)
        {
            this.appointmentRepository = appointmentRepository;
        }
        public Appointment GetAppointmentById(string appointmentId)
        {
            Guid appointmentGuid = Guid.Empty;
            if (!Guid.TryParse(appointmentId, out appointmentGuid))
                throw new Exception("Invalid guid format");
            var appointment = appointmentRepository.GetAppointmentById(appointmentGuid);
            if (appointment == null)
                throw new EntityNotFoundException(appointmentGuid);
            return appointment;
        }
    }

}

