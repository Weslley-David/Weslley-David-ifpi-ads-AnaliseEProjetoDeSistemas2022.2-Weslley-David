using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using car_online.Models;

namespace car_online.Models
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options){}

        public DbSet<CreditCard> CreditCard {get; set;}
        public DbSet<Payment> Payment {get; set;}
        public DbSet<Ticket> Ticket {get; set;}
        public DbSet<Request> Request {get; set;}
        public DbSet<Consumer> Consumer {get; set;}
        public DbSet<Product> Product {get; set;}
        public DbSet<CarVersion> CarVersion {get;set;}
        public DbSet<Brand> Brand {get;set;}
        public DbSet<Login> Login { get; set; }
    }
}