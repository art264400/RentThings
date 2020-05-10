using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentThings.Models
{
    public class TakenProduct
    {
        public int Id { get; set; }
        public DateTime? DateTaken { get; set; }
        public DateTime? DataReturn { get; set; }
        public bool IsDeleted { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public TakenProduct()
        {
            IsDeleted = false;
        }
    }
}