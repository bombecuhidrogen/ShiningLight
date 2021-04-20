using ShinigLight.ApplicationLogic.Abstractions;
using ShinigLight.ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShinigLight.ApplicationLogic.Services
{
    public class ServicesService
    {
        private IServiceRepository serviceRepository;
        public ServicesService(IServiceRepository serviceRepository)
        {
            this.serviceRepository = serviceRepository;
        }
        public DataModels.Services GetServiceById(string serviceId)
        {
            Guid serviceGuid = Guid.Empty;
            if (!Guid.TryParse(serviceId, out serviceGuid))
                throw new Exception("Invalid guid format");
            var service = serviceRepository.GetServiceById(serviceGuid);
            if (service == null)
                throw new EntityNotFoundException(serviceGuid);
            return service;
        }
    }
}
