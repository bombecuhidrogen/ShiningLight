using ShinigLight.ApplicationLogic.Abstractions;
using ShinigLight.ApplicationLogic.DataModels;
using ShinigLight.ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShinigLight.ApplicationLogic.Services
{
    public class InvoicesService
    {
        private IInvoiceRepository invoiceRepository;
        public InvoicesService(IInvoiceRepository invoiceRepository)
        {
            this.invoiceRepository = invoiceRepository;
        }
        public Invoice GetInvoiceById(string invoiceId)
        {
            Guid invoiceGuid = Guid.Empty;
            if (!Guid.TryParse(invoiceId, out invoiceGuid))
                throw new Exception("Invalid guid format");
            var invoice = invoiceRepository.GetInvoicesById(invoiceGuid);
            if (invoice == null)
                throw new EntityNotFoundException(invoiceGuid);
            return invoice;
        }
    }
}
