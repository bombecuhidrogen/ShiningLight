using ShinigLight.ApplicationLogic.Abstractions;
using ShinigLight.ApplicationLogic.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShiningLight.DataAccess
{
    public class AppointmentRepository : BaseRepository <Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(ShiningLightDBContext dbContext): base(dbContext)
        {

        }
        public Appointment GetAppointmentById(Guid id)
        {
            return dbContext.Appointments
                .Where(appointment => appointment.ID == id)
                .SingleOrDefault();
        }
    }
}
