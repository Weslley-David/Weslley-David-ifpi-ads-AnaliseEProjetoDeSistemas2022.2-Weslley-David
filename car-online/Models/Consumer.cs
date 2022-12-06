using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace car_online.Models
{
    public class Consumer
    {
        public int id {get;set;}
        [Display(Name = "Nome")]
        public string? name {get;set;}
        [Display(Name = "telefone")]
        public string? phone {get;set;}
        public string? email {get;set;}
        public string? cpf {get;set;}
        public virtual ICollection<Request>? Request {get;set;}
    }
}