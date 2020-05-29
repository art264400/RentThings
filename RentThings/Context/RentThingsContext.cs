using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using RentThings.Models;

namespace RentThings.Context
{
    public class RentThingsContext : DbContext
    {
        public RentThingsContext() : base("RentThingsContext") {}
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<TakenProduct> TakenProducts { get; set; }
    }

    public class LibraryDbInit : DropCreateDatabaseAlways<RentThingsContext>
    {
        protected override void Seed(RentThingsContext db)
        {
            db.Roles.Add(new Role
            {
                Id = 1,
                Name = "Admin",
            });
            db.Roles.Add(new Role
            {
                Id = 2,
                Name = "User",
            });
            db.Users.Add(new User
            {
                Login = "mino",
                Name = "Артур Губайдуллин",
                Password = "123",
                RoleId = 1
            });
            db.Users.Add(new User
            {
                Login = "mino2",
                Name = "Иван",
                Password = "123",
                RoleId = 2
            });
            db.Categories.Add(new Category
            {
                Name = "Велосипеды"
            });
            db.Categories.Add(new Category
            {
                Name = "Дроны"
            });
            db.Products.Add(new Product
            {
                CategoryId = 1,
                Discription = "Велосипед новый, 18 скоростей",
                Name = "Велосипед string",
                PhotoUrl = "https://cache3.youla.io/files/images/780_780/59/69/5969b790f8efdc19845023c2.jpg",
                Price = 200
            });
            
            base.Seed(db);
        }
    }
}