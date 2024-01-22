using Microsoft.EntityFrameworkCore;
using MultipleDbApp.Models;

namespace MultipleDbApp.Data;

public class SecondaryAppDbContext (DbContextOptions<SecondaryAppDbContext> options) : DbContext (options)
{
    public virtual DbSet<Login>? Logins { get; set; }
}