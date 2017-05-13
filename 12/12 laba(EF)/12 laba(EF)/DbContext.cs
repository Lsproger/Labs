using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace _12_laba_EF_
{
    public partial class MyDbContext:DbContext
    {
        public MyDbContext()
            : base("name=DbContext")
        {
        }

        public virtual DbSet<Superhero> Superheroes { get; set; }
        public virtual DbSet<Superteam> Superteams { get; set; }
   

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Superteam>()
                .HasMany(e => e.Superheroes)
                .WithRequired(e => e.Superteam)
                .WillCascadeOnDelete(false);
        }
    }
}
