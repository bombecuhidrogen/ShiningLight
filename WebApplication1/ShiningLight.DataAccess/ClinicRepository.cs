using ShinigLight.ApplicationLogic.Abstractions;
using ShinigLight.ApplicationLogic.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShiningLight.DataAccess
{
    public class ClinicRepository : BaseRepository<Clinic>, IClinicRepository
    {
        public ClinicRepository(ShiningLightDBContext dbContext) : base(dbContext)
        {

        }
        public Clinic GetClinicById(Guid id)
        {
            return dbContext.Clinics
                .Where(clinic => clinic.ID == id)
                .SingleOrDefault();
        }
    }
}
