using System;


namespace ShinigLight.ApplicationLogic.Abstractions
{
    public interface IServiceRepository : IRepository<DataModels.Services>
    {
        
        DataModels.Services GetServiceById(Guid serviceGuid);
    }
}
