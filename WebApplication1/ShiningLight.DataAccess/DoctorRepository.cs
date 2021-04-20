using ShinigLight.ApplicationLogic.Abstractions;
using ShinigLight.ApplicationLogic.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShiningLight.DataAccess
{
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorsRepository
    {
        public DoctorRepository(ShiningLightDBContext dbContext) : base(dbContext)
        {

        }

        public Doctor GetDoctorById(Guid id)
        {
            return dbContext.Doctors.Where(doctor => doctor.ID == id).SingleOrDefault();
        }
    }
}
