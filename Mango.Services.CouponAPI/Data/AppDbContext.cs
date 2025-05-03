using Microsoft.EntityFrameworkCore;

namespace Mango.Services.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Coupon> Coupons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coupon>().ToTable("Coupons");
            modelBuilder.Entity<Coupon>().HasKey(c => c.CouponId);
            modelBuilder.Entity<Coupon>().Property(c => c.CouponCode).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Coupon>().Property(c => c.DiscountAmount).IsRequired();
            modelBuilder.Entity<Coupon>().Property(c => c.MinAmount).IsRequired();
            modelBuilder.Entity<Coupon>().Property(c => c.LastUpdated).IsRequired();
        }
    }
    {
    }
}
