using ShinigLight.ApplicationLogic.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShinigLight.ApplicationLogic.Abstractions
{
    public interface IInvoiceRepository : IRepository<Invoice>
    {
        Invoice GetInvoicesById(Guid id);
    }
}
