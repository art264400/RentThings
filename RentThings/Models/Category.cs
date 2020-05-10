using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentThings.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public Category()
        {
            IsDeleted = false;
        }
    }
}