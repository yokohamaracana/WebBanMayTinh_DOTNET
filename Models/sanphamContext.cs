using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebBanMayTinh.Models
{
    public partial class sanphamContext : DbContext
    {
        public sanphamContext()
        {
        }

        public sanphamContext(DbContextOptions<sanphamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Coment> Coments { get; set; }
        public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderProduct> OrderProducts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("Data Source=127.0.0.1;Database=sanpham;User Id=root;Password=;SSL Mode=0;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("admin");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("brand");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("cart");

                entity.HasIndex(e => e.IdProduct, "id_product");

                entity.HasIndex(e => e.IdUsers, "id_users");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("int(11)")
                    .HasColumnName("amount");

                entity.Property(e => e.IdProduct)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_product");

                entity.Property(e => e.IdUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_users");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cart_ibfk_2");

                entity.HasOne(d => d.IdUsersNavigation)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.IdUsers)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cart_ibfk_1");
            });

            modelBuilder.Entity<Coment>(entity =>
            {
                entity.ToTable("coment");

                entity.HasIndex(e => e.IdProduct, "id_product");

                entity.HasIndex(e => e.IdUser, "id_user");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("content");

                entity.Property(e => e.IdProduct)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_product");

                entity.Property(e => e.IdUser)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_user");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.Coments)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("coment_ibfk_1");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Coments)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("coment_ibfk_2");
            });

            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.ToTable("event");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("order");

                entity.HasIndex(e => e.IdUser, "id_user");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("district");

                entity.Property(e => e.IdUser)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_user");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.OtherNote)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("other_note");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("phone");

                entity.Property(e => e.Status)
                    .HasColumnType("int(11)")
                    .HasColumnName("status");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_ibfk_1");
            });

            modelBuilder.Entity<OrderProduct>(entity =>
            {
                entity.ToTable("order_product");

                entity.HasIndex(e => e.IdOrder, "id_order");

                entity.HasIndex(e => e.IdProduct, "id_product");

                entity.HasIndex(e => e.IdUsers, "id_users");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("int(11)")
                    .HasColumnName("amount");

                entity.Property(e => e.IdOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_order");

                entity.Property(e => e.IdProduct)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_product");

                entity.Property(e => e.IdUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_users");

                entity.Property(e => e.Quantity)
                    .HasColumnType("int(11)")
                    .HasColumnName("quantity");

                entity.HasOne(d => d.IdOrderNavigation)
                    .WithMany(p => p.OrderProducts)
                    .HasForeignKey(d => d.IdOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_product_ibfk_1");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.OrderProducts)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_product_ibfk_2");

                entity.HasOne(d => d.IdUsersNavigation)
                    .WithMany(p => p.OrderProducts)
                    .HasForeignKey(d => d.IdUsers)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_product_ibfk_3");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.HasIndex(e => e.Brand, "brand");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnType("int(11)")
                    .HasColumnName("brand");

                entity.Property(e => e.Desc)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("desc");

                entity.Property(e => e.DiscountPrice)
                    .HasColumnType("int(11)")
                    .HasColumnName("discount_price");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("name");

                entity.Property(e => e.Price)
                    .HasColumnType("int(11)")
                    .HasColumnName("price");

                entity.Property(e => e.ShortDesc)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("short_desc");

                entity.Property(e => e.Sold)
                    .HasColumnType("int(11)")
                    .HasColumnName("sold");

                entity.Property(e => e.View)
                    .HasColumnType("int(11)")
                    .HasColumnName("view");

                entity.HasOne(d => d.BrandNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Brand)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("product_ibfk_1");
            });

            modelBuilder.Entity<Rate>(entity =>
            {
                entity.ToTable("rate");

                entity.HasIndex(e => e.IdProduct, "id_product");

                entity.HasIndex(e => e.IdUser, "id_user");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.IdProduct)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_product");

                entity.Property(e => e.IdUser)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_user");

                entity.Property(e => e.Stars)
                    .HasColumnType("int(11)")
                    .HasColumnName("stars");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.RateIdProductNavigations)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rate_ibfk_1");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.RateIdUserNavigations)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rate_ibfk_2");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("phone_number");
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
