using System;
using System.Collections.Generic;
using System.Text;

namespace ShinigLight.ApplicationLogic.DataModels
{
    public class Invoice
    {
        public Guid ID { get; set; }
        public User User { get; set; }
        public decimal Price { get; set; }
        public string PaymentMethod { get; set; }
    }
}
