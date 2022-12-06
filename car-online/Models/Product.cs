using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace car_online.Models
{
    public class Product
    {
        public int id {get;set;}
        [Display(Name = "Nome")]
        public string? name {get;set;}
        [Display(Name = "Descrição")]
        public string? description {get;set;}
        [Display(Name = "Valor")]
        public float value {get; set;}
        [Display(Name = "Usado")]
        public bool used {get;set;}
        //produtos
        public virtual ICollection<Request>? items {get;set;}

        //version
        public int? carVersionId { get; set; }
        public virtual CarVersion? carVersion { get; set; }

        //brand
        public int? BrandId { get; set; }
        public virtual Brand? brand { get; set; }
    }
}