using ShinigLight.ApplicationLogic.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShinigLight.ApplicationLogic.Abstractions
{
    public interface IClinicRepository : IRepository<Clinic>
    {
        Clinic GetClinicById(Guid id);
    }
}
