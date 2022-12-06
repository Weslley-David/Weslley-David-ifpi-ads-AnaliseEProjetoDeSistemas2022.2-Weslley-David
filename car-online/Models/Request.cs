using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_online.Models
{
    public class Request
    {
        public int id {get;set;}
        //consumidor
        public int? consumerId { get; set; }
        public virtual Consumer? consumer { get; set; }
        //pagamento
        public Payment? Payment { get; set; }
         //Product
        public int? productId { get; set; }
        public virtual Product? product { get; set; }
    }
}