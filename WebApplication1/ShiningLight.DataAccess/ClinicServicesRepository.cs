using ShinigLight.ApplicationLogic.Abstractions;
using ShinigLight.ApplicationLogic.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShiningLight.DataAccess
{
    public class ClinicServicesRepository : BaseRepository<ClinicServices>, IClinicServiceRepository
    {
        public ClinicServicesRepository(ShiningLightDBContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<ClinicServices> GetServicesByClinicId(Guid clinicId)
        {
            return dbContext.ClinicsServices
                .Where(clinicServices => clinicServices.ClinicID == clinicId)
                .AsEnumerable();
        }
    }
}
