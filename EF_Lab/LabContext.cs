using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;

namespace EF_Lab
{
    public class LabContext : DbContext
    {
        public DbSet<Principal> Principals { get; set; }
        public DbSet<Dependent> Dependents { get; set; }

        //Data Source=.\SQLEXPRESS;Initial Catalog=EF_Lab;Integrated Security=True

        public LabContext(DbContextOptions options) : base(options) { }

        private static readonly ILoggerFactory LoggerFactory
            = new LoggerFactory(new[] { new DebugLoggerProvider() });

        public static LabContext CreateContext(string connection)
        {
            var options = new DbContextOptionsBuilder<LabContext>()
                .UseSqlServer(connection)
                .UseLoggerFactory(LoggerFactory)
                .Options;

            return new LabContext(options);
        }

        //: base("ConnectionName")
        //{
        //    Configuration.LazyLoadingEnabled = true;
        //    Configuration.ProxyCreationEnabled = true;
        //    Database.SetInitializer<CustomerModelDataContext>(new Initializer<CustomerModelDataContext>());
        //    //Database.Log = message => DBLog.WriteLine(message);
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    //modelBuilder.Entity<Principal>()
        //    //    .ToTable("Principals")

        //}
        
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder
        //        .UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=EF_Lab;Integrated Security=True");
        //}
    }
}
