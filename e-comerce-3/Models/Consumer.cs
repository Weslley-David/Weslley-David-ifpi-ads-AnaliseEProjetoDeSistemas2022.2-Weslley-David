using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comerce_3.Models
{
    public class Consumer
    {
        public int id {get;set;}
        public string? name {get;set;}
        public string? phone {get;set;}
        public string? email {get;set;}
        public string? cpf {get;set;}
        public virtual ICollection<Request>? Request {get;set;}
    }
}