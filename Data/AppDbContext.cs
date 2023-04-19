using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NTTData.Models;

namespace NTTData.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Address>? Addresses { get; set; }
    public DbSet<Client>? Clients { get; set; }
    public DbSet<Order>? Orders { get; set; }
    public DbSet<Product>? Products { get; set; }

}
