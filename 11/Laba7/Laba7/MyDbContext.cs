namespace Laba7
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=DbContext")
        {
        }

        public virtual DbSet<Airplane> Airplanes { get; set; }
        public virtual DbSet<Crewmember> Crewmembers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airplane>()
                .HasMany(e => e.Crewmembers)
                .WithRequired(e => e.Airplane)
                .WillCascadeOnDelete(false);
        }
    }
}
