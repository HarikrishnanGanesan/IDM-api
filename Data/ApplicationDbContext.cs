using Microsoft.EntityFrameworkCore;
using IDMApi.Models;
using System.ComponentModel.DataAnnotations;


namespace IDMApi.Data
{
    public class ApplicationDbContext : DbContext
    {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {

            }    
       public DbSet<Employee> Employee { get; set; }

    }
}