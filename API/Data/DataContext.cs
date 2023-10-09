using API.Entities;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
        SQLitePCL.Batteries.Init();
    }
    

public DbSet<AppUser> Users { get; set;}

}
