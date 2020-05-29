using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentThings.Context;
using RentThings.Interfaces;
using RentThings.Models;

namespace RentThings.Services
{
    public class EntityRentService : IRentService
    {
        public Product[] GetAllFreeProducts()
        {
            using (var db = new RentThingsContext())
            {
                return db.Products.Where(m => m.IsDeleted == false && m.IsTaken == false).Include(m=>m.Category).ToArray();
            }
        }

        public Product GetProductById(int id)
        {
            using (var db = new RentThingsContext())
            {
                return db.Products.FirstOrDefault(m=>m.Id==id);
            }
        }
    }
}