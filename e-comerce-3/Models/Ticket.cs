using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comerce_3.Models
{
    public class Ticket: Payment
    {
        public string? code {get;set;}
    }
}