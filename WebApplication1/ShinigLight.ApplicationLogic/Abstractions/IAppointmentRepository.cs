using ShinigLight.ApplicationLogic.DataModels;
using System;


namespace ShinigLight.ApplicationLogic.Abstractions
{
    public interface IAppointmentRepository : IRepository<Appointment>
    {
        Appointment GetAppointmentById(Guid id);
    }
}
