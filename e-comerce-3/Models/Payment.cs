using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comerce_3.Models
{
    public class Payment
    {
        public int id {get; set;}
        public float value {get;set;}
        public bool confirmation {get;set;}
        
        //Order
        public int? RequestId { get; set; }
        public virtual Request? Request { get; set; }
    }
}