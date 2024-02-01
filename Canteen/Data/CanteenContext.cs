using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Canteen.Model;

namespace Canteen.Data
{
    public class CanteenContext : DbContext
    {
        public CanteenContext (DbContextOptions<CanteenContext> options)
            : base(options)
        {
        }

        public DbSet<Canteen.Model.Customer> Customer { get; set; } = default!;

        public DbSet<Canteen.Model.FoodItem>? FoodItem { get; set; }

        public DbSet<Canteen.Model.OrderDetails>? OrderDetails { get; set; }

        public DbSet<Canteen.Model.Vendor>? Vendor { get; set; }

        public DbSet<Canteen.Model.Wallet>? Wallet { get; set; }
    }
}
