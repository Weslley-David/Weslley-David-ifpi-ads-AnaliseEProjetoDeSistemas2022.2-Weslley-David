using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace car_online.Models
{
    public class Ticket: Payment
    {
        [Display(Name = "Código")]
        public string? code {get;set;}
        [Display(Name = "Quantidade")]
        public int quantity {get;set;}
    }
}