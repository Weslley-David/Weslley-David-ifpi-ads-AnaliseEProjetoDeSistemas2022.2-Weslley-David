using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace car_online.Models
{
    public class CreditCard: Payment
    {
        [Display(Name = "Número")]
        public string? number {get;set;}
        [Display(Name = "Autorizar Débito")]
        public bool debitAuthorization {get;set;}
    }
}