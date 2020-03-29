using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;


namespace DatingApp.API.Data
{
    public class DataContext: DbContext // add this base class ,and install and reference to EF
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Value> Values { get; set; }  // Values is table name
        public DbSet<User> Users{ get; set;}

    }
}
