using Lunafit.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Lunafit.Data
{
    public class LunafitDbContext : DbContext
    {
        private readonly string _connectionString;
        public LunafitDbContext(DbContextOptions<LunafitDbContext> options) : base(options)
        {
            _connectionString = Config.ServiceEndPoints.ConnectionString;
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseSqlServer(_connectionString);
       
        public virtual DbSet<ToDo> ToDo { get; set; }

    }
}
