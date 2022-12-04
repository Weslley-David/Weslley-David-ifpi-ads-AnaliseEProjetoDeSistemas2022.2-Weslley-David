using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comerce_3.Models
{
    public class CreditCard: Payment
    {
        public string? number {get;set;}
        public bool debitAuthorization {get;set;}
    }
}