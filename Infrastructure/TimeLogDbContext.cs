using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure;

public class TimeLogDbContext : DbContext
{
    public TimeLogDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<User> User { get; set; }
}
