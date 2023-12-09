using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration.UserSecrets;
using Microsoft.Identity.Client;
using PizzaStore;
using PizzaStore.Entities;

    namespace PizzaStore.Data;

    public class dbContext : DbContext
    {
        public dbContext (DbContextOptions<dbContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Product { get; set; } = default!;

        public DbSet<Order> Order { get; set; } = default!;
        
        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { Roleid = 1, RoleName = "Admin" },
                new Role { Roleid = 2, RoleName = "User" }
            );  

            modelBuilder.Entity<User>().HasData(
                new User {UserId = 1, Email = "Coolcody171@gmail.com",FirstName = "Cody", LastName = "Criner", RoleId = 1,PasswordHash= "A0A7B968A20E3FB39B1B8AA4877F29597D56FFBD907891FEEDABBF940E70633F586F67BFF07A4975CBA22A22F7F1B988F2DD1A6A4867A60AC1B25C417B3EA99C", PasswordSalt = "FE5D976E712E3122CB81BBB3B85AE2DD360020C7027E30CDC3375C7C36FF6A807C11C2D9963E28F806DA5BC9A22466F4B6C523FBE104EFCFCD05C47C609CF339"},
                new User {UserId = 2, Email = "Crinerc21@students.ecu.edu",FirstName = "Kyle", LastName = "Criner", RoleId = 2, PasswordHash = "FA6BA0AE07E34A0916FFF2ECF20D995FE05A52D44A385566B45D580E61CEF66344466DC87573ABD76BCF26EC823E4F94A5C82CCFE57EE4ABD7A6073383280DA3", PasswordSalt = "686981512FBED86F8EE4FE8673F899332D3D0BFCEAD08F9E4DF6359E3AB5DCAC2F66583572100E7F73439768C8AF803D2B8B45D44FCF8E00F7CC15B8B15528A7"}
            );
        }

    public void SeedData()
    {
        if(!Product.Any() && !Order.Any())
        {
            var intialOrder = new List<Order>
            {
                new Order
                {
                    OrderName = "Order 1",
                    Iscompleted = true,
                    OrderDate = DateTime.Parse("10-03-2023"),
                },
                new Order
                {
                    OrderName = "Order 2",
                    Iscompleted = true,
                    OrderDate = DateTime.Parse("10-03-2023"),
                },
            };
            Order.AddRange(intialOrder);
            SaveChanges();
            
            var initalProduct = new List<Product>
            {
                new Product
                {
                    ProductName = "Cheese",
                    IsComplete = true,
                    Duedate = DateTime.Parse("10-03-2023"),
                },
                new Product
                {
                    ProductName = "Pepperoni",
                    IsComplete = true,
                    Duedate = DateTime.Parse("10-03-2023"),
                },
            };
            Product.AddRange(initalProduct);
            SaveChanges();
        }
    }
    


 }

