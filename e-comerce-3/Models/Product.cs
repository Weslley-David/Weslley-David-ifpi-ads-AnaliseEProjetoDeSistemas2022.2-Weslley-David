using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comerce_3.Models
{
    public class Product
    {
        public int id {get;set;}
        public string? description {get;set;}
        public string? name {get;set;}
        public float value {get; set;}
        public bool available {get;set;}
       

        //produtos
        public virtual ICollection<Request>? items {get;set;}
    }
}