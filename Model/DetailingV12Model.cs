using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DetailingV12App.Model
{
    public partial class DetailingV12Model : DbContext
    {
        public DetailingV12Model()
            : base("name=DetailingV12Model")
        {
        }

        public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<LogPass> LogPasses { get; set; }
        public virtual DbSet<MyOrder> MyOrders { get; set; }
        public virtual DbSet<OrderList> OrderLists { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<List>()
                .Property(e => e.TelephoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<List>()
                .HasMany(e => e.OrderLists)
                .WithOptional(e => e.List)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<LogPass>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<LogPass>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<LogPass>()
                .HasMany(e => e.Lists)
                .WithOptional(e => e.LogPass)
                .HasForeignKey(e => e.IDLogPass);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Lists)
                .WithOptional(e => e.Role)
                .HasForeignKey(e => e.IDRole);

            modelBuilder.Entity<Service>()
                .Property(e => e.IMG)
                .IsUnicode(false);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.OrderLists)
                .WithOptional(e => e.Service)
                .HasForeignKey(e => e.ServicesID);
        }
    }
}
