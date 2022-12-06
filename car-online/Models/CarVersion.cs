using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_online.Models
{
    public class CarVersion
    {
        public int id {get;set;}
        public string? name {get;set;}
        public string? description {get;set;}
        public virtual ICollection<Product>? product {get;set;}
    }
}