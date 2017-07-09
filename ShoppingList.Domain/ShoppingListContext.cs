using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;
using ShoppingList.Domain.Models;

namespace ShoppingList.Domain
{
    public class ShoppingListContext : DbContext, IShoppingListContext
    {
        public ShoppingListContext(DbContextOptions<ShoppingListContext> options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shop> Shops { get; set; }
    }
}
