using App.Domain.Core.Entities;
using App.Domain.Core.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bogus;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Infrastructure.Data.SqlServer;

public partial class MarketPlaceContext : IdentityDbContext<IdentityUser<int>, IdentityRole<int>, int>
{
    public MarketPlaceContext()
    {
    }

    public MarketPlaceContext(DbContextOptions<MarketPlaceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Booth> Booths { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<SalesMan> SalesMen { get; set; }

    public virtual DbSet<SubCategory> SubCategories { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public DbSet<Factor> Factors { get; set; }

    public DbSet<FactorProduct> FactorProduct { get; set; }

    public DbSet<CustomerHistory> CustomerHistories { get; set; }

    public DbSet<Bid> Bids { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=SINA;Database=Market_Place_Test;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var faker = new Faker();

        Randomizer.Seed = new Random(7531);

        modelBuilder.Entity<Admin>(entity =>
        {
            entity.ToTable("Admin");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(250);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50).IsRequired(false);
            entity.Property(e => e.CardNumber).HasMaxLength(150).IsRequired(false);
            entity.Property(e => e.ShebaNumber).HasMaxLength(500).IsRequired(false);
            entity.Property(e => e.IsDeleted).HasColumnType("bit").IsRequired();
            entity.Property(e => e.RegisterDate).HasColumnType("datetime").ValueGeneratedOnAdd();
            entity.Property(e => e.BirthDate).HasColumnType("datetime").ValueGeneratedOnAdd();

        });

        modelBuilder.Entity<Bid>(entity =>
        {
            entity.ToTable("Bids");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.BasePrice).HasColumnType("int").IsRequired();
            entity.Property(e => e.IsOpen).HasColumnType("bit").IsRequired();
            entity.Property(e => e.OpeningTime).HasColumnType("datetime");
            entity.Property(e => e.ClosingTime).HasColumnType("datetime");
            entity.Property(e => e.HasWinner).HasColumnType("bit").IsRequired();
            entity.Property(e => e.HighestPrice).HasColumnType("int").IsRequired();


            entity.HasOne(e => e.Product)
                .WithOne(d => d.Bid)
                .HasForeignKey<Product>(e => e.BidId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired(false);

            entity.HasOne(e => e.WinnerCustomer)
                .WithOne(d => d.Bid)
                .HasForeignKey<Customer>(e => e.BidId)
                .IsRequired(false);

            var price = faker.Random.Int(1000, 10000000);
            var numbers = Enumerable.Range(1, 50).ToList();
            numbers.OrderBy(x => faker.Random.Int()).ToList();


            for (var i = 1; i <= 50; i++)
            {
                entity.HasData(
                    new Bid
                    {
                        Id = i,
                        BasePrice = price,
                        HighestPrice = price,
                        OpeningTime = Convert.ToDateTime("08/12/2023 12:00:00 AM"),
                        ClosingTime = Convert.ToDateTime("08/20/2023 12:00:00 AM"),
                        IsOpen = false,
                        HasWinner = false,
                        ProductId = numbers[i-1]
                    }
                );
            }
        });

        modelBuilder.Entity<Booth>(entity =>
        {
            entity.ToTable("Booth");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ImageUrl).HasMaxLength(250);
            entity.Property(e => e.Name).HasMaxLength(250);

            for (var i = 1; i <= 50; i++)
            {
                entity.HasData(
                    new Booth
                    {
                        Id = i,
                        Name = faker.Lorem.Word(),
                        Description = faker.Lorem.Sentence(),
                        Medal = faker.Random.Enum<Medal>(),
                    }
                );
            }
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ImageUrl).IsRequired(false);

            for (var i = 1; i <= 10; i++)
            {
                entity.HasData(
                    new Category
                    {
                        Id = i,
                        Name = faker.Commerce.Categories(1).First()
                    }
                );
            }
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(250);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.CardNumber).HasMaxLength(150);
            entity.Property(e => e.ShebaNumber).HasMaxLength(500);
            entity.Property(e => e.IsDeleted).HasColumnType("bit").IsRequired();
            entity.Property(e => e.RegisterDate).HasColumnType("datetime");
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.Address).HasMaxLength(550).IsRequired();

            for (var j = 1; j <= 50; j++)
            {
                entity.HasData(
                    new Customer
                    {
                        Id = j,
                        FirstName = faker.Name.FirstName(),
                        LastName = faker.Name.LastName(),
                        UserName = faker.Internet.UserName(),
                        Email = faker.Internet.Email(),
                        Address = faker.Address.City(),
                        BirthDate = Convert.ToDateTime("06/12/1985 12:00:00 AM"),
                        RegisterDate = Convert.ToDateTime("06/12/2023 12:00:00 AM")
                    }
                );
            }

        });

        modelBuilder.Entity<CustomerHistory>(entity =>
        {
            entity.ToTable("CustomerHistory");


            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Customer).WithMany()
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_CustomerHistory_Customer");

            entity.HasOne(d => d.Product).WithMany()
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerHistory_Product");

        });

        modelBuilder.Entity<Comment>(entity =>
        {
	        entity.ToTable("Comments");

	        entity.HasKey(e => e.Id);
            entity.Property(e => e.Message).HasMaxLength(200);
            entity.Property(e => e.IsDeleted).HasColumnType("bit");
            entity.Property(e => e.IsConfirmed).HasColumnType("bit");

            entity.HasOne(d => d.Product).WithMany(p => p.Comments)
	            .HasForeignKey(d => d.ProductId)
	            .OnDelete(DeleteBehavior.Cascade)
	            .HasConstraintName("FK_Comment_Product");

            entity.HasOne(d => d.Customer).WithMany(p => p.Comments)
	            .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Comment_Customer");

            var numbers = Enumerable.Range(1, 50).ToList();
            numbers.OrderBy(x => faker.Random.Int()).ToList();
            // watch this
            for (var i = 1; i <= 50; i++)
            {
                entity.HasData(
                    new Comment
                    {
                        Id = i,
                        CustomerId = numbers[i-1],
                        IsConfirmed = false,
                        IsDeleted = false,
                        Message = faker.Lorem.Sentence(),
                        ProductId = numbers[i-1]
                    }
                );
            }
        });

        modelBuilder.Entity<Factor>(entity =>
        {
            entity.ToTable("Factors");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.SumOfPrice).HasColumnType("int");

            entity.HasOne(e => e.Customer)
                .WithOne()
                .HasForeignKey<Factor>("CustomerId1");

            for (var i = 1; i <= 50; i++)
            {
                entity.HasData(
                    new Factor
                    {
                        Id = i,
                        CustomerId = i,
                        SumOfPrice = faker.Random.Int(1000, 1000000)
                    }
                );
            }
        });

        modelBuilder.Entity<FactorProduct>(entity =>
        {
            entity.ToTable("FactorProduct");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(fp => fp.Factor)
                   .WithMany()
                   .HasForeignKey(fp => fp.FactorID)
                   .OnDelete(DeleteBehavior.NoAction)
                   .HasConstraintName("FK_FactorProduct_Factor");

            entity.HasOne(fp => fp.Product)
                   .WithMany()
                   .HasForeignKey(fp => fp.ProductId)
                   .OnDelete(DeleteBehavior.NoAction)
                   .HasConstraintName("FK_FactorProduct_Product");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(e => e.Description).HasMaxLength(400);
            entity.Property(e => e.ImageUrl).HasMaxLength(250).IsRequired(false);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.IsConfirmed).HasColumnType("bit");
            entity.Property(e => e.IsDeleted).HasColumnType("bit");
            entity.Property(e => e.Price).HasMaxLength(100);

            entity.HasOne(d => d.SubCategory).WithMany(p => p.Products)
                .HasForeignKey(d => d.SubCategoryId)
                .HasConstraintName("FK_Product_SubCategory")
                .IsRequired();

            entity.HasOne(e => e.Booth).WithMany(d => d.Products)
                .HasForeignKey(d => d.BoothId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Product_Booth")
                .IsRequired();
                

            var numbers = Enumerable.Range(1, 50).ToList();
            numbers.OrderBy(x => faker.Random.Int(max:555)).ToList();

            var numbers1 = Enumerable.Range(1, 25).ToList();
            numbers1.OrderBy(x => faker.Random.Int(min:0)).ToList();
            numbers1 = numbers1.Concat(numbers1).ToList();

            var numbers2 = Enumerable.Range(1, 50).ToList();
            numbers2.OrderBy(x => faker.Random.Int(max:777)).ToList();

            for (var i = 1; i <= 50; i++)
            {
                entity.HasData(
                    new Product
                    {
                        Id = i,
                        Name = faker.Commerce.ProductName(),
                        IsDeleted = false,
                        Description = faker.Lorem.Paragraph(),
                        IsConfirmed = false,
                        SubCategoryId = numbers1[i-1],
                        BoothId = numbers2[i-1],
                        BidId = numbers[i-1],
                        Price = faker.Commerce.Price()
                    }
                );
            }
        });

        modelBuilder.Entity<SalesMan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Sealer");

            entity.ToTable("SalesMan");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(250);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50); 
            entity.Property(e => e.CardNumber).HasMaxLength(150);
            entity.Property(e => e.ShebaNumber).HasMaxLength(500);
            entity.Property(e => e.IsDeleted).HasColumnType("bit").IsRequired();
            entity.Property(e => e.RegisterDate).HasColumnType("datetime");
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.Address).HasMaxLength(550).IsRequired();
            entity.Property(e => e.Wage).HasColumnType("int").IsRequired();
            entity.Property(e => e.Address).HasMaxLength(550).IsRequired();

            entity.HasOne(d => d.Booth)
	            .WithOne(e => e.SalesMan)
	            .HasForeignKey<Booth>(p => p.Id);

            for (var i = 1; i <= 50; i++)
            {
                entity.HasData(
                    new SalesMan
                    {
                        Id = i,
                        FirstName = faker.Name.FirstName(),
                        LastName = faker.Name.LastName(),
                        UserName = faker.Internet.UserName(),
                        BirthDate = Convert.ToDateTime("06/12/1985 12:00:00 AM"),
                        Email = faker.Internet.Email(),
                        IsDeleted = false,
                        RegisterDate = Convert.ToDateTime("06/12/2023 12:00:00 AM"),
                        PhoneNumber = faker.Phone.PhoneNumber("###########"),
                        Address = faker.Address.City()
                    }
                );
            }
        });

        modelBuilder.Entity<SubCategory>(entity =>
        {
            entity.ToTable("SubCategory");

            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ImageUrl).IsRequired(false);
            entity.Property(e => e.Description).HasMaxLength(5000).IsRequired(false);

            entity.HasOne(d => d.Category).WithMany(p => p.SubCategories)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubCategory_Category");

            for (var i = 1; i <= 25; i++)
            {
                entity.HasData(
                    new SubCategory
                    {
                        Id = i,
                        CategoryId = faker.Random.Int(1, 10),
                        Name = faker.Lorem.Word()
                    }
                );
            }
        });


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
