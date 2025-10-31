using System;
using System.Data.Entity;
using System.Linq;

namespace MetroMap_HCM.DAL
{
    public class Model1 : DbContext
    {
        public Model1()
     : base("name=Model1")
        {
            this.Configuration.LazyLoadingEnabled = false;

        }

        public virtual DbSet<Ga> Gas { get; set; }
        public virtual DbSet<Tuyen> Tuyens { get; set; }
        public virtual DbSet<LienKet> LienKets { get; set; }
        public virtual DbSet<LichTrinh> LichTrinhs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình rõ ràng quan hệ LienKet ↔ Ga
            modelBuilder.Entity<LienKet>()
                .HasRequired(l => l.Ga1)
                .WithMany()
                .HasForeignKey(l => l.MaGa1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LienKet>()
                .HasRequired(l => l.Ga2)
                .WithMany()
                .HasForeignKey(l => l.MaGa2)
                .WillCascadeOnDelete(false);
        }

    }
}
