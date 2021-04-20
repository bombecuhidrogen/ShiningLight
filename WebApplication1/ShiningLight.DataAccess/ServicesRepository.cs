using ShinigLight.ApplicationLogic.Abstractions;
using ShinigLight.ApplicationLogic.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShiningLight.DataAccess
{
    public class ServicesRepository : BaseRepository<Services>, IServiceRepository
    {
        public ServicesRepository(ShiningLightDBContext dbContext) : base(dbContext)
        {

        }

        public Services GetServiceById(Guid serviceGuid)
        {
            return dbContext.Services.Where(service => service.ID == serviceGuid).SingleOrDefault();
        }
    }
}
