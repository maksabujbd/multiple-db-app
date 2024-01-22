using Microsoft.EntityFrameworkCore;
using MultipleDbApp.Models;

namespace MultipleDbApp.Data;

public class PrimaryAppDbContext(DbContextOptions<PrimaryAppDbContext> options) : DbContext(options)
{
    public virtual DbSet<User>? Users { get; set; }
}
