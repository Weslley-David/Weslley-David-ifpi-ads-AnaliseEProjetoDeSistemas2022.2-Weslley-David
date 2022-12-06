using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace car_online.Models
{
    public class Payment
    {
        public int id {get; set;}
        [Display(Name = "Valor")]
        public float value {get;set;}
        [Display(Name = "Confirmação")]
        public bool confirmation {get;set;}
        
        //Order
        public int? RequestId { get; set; }
        public virtual Request? Request { get; set; }
    }
}