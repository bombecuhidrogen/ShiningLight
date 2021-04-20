using ShinigLight.ApplicationLogic.Abstractions;
using ShinigLight.ApplicationLogic.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShiningLight.DataAccess
{
    public class InvoicesRepository : BaseRepository<Invoice>, IInvoiceRepository
    {
        public InvoicesRepository(ShiningLightDBContext dbContext) : base(dbContext)
        {

        }
        public Invoice GetInvoicesById(Guid id)
        {
            return dbContext.Invoices.Where(invoice => invoice.ID == id).SingleOrDefault();
        }
    }
}
