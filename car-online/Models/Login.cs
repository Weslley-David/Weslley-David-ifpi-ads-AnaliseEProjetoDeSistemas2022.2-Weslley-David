using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace car_online.Models
{
    public class Login
    {
        public int id {get;set;}
        [Display(Name = "username")]
        public string? username {get;set;}
        [Display(Name = "Password")]
        public string? password {get;set;}

    }
}