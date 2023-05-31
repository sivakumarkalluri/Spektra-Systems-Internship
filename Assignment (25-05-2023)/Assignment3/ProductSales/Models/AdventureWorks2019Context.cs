using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProductSales.Models;

public partial class AdventureWorks2019Context : DbContext
{
    public AdventureWorks2019Context()
    {
    }

    public AdventureWorks2019Context(DbContextOptions<AdventureWorks2019Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<ProductSubcategory> ProductSubcategories { get; set; }

    public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK_Product_ProductID");

            entity.ToTable("Product", "Production", tb => tb.HasComment("Products sold or used in the manfacturing of sold products."));

            entity.Property(e => e.ProductId).HasComment("Primary key for Product records.");
            entity.Property(e => e.Class)
                .IsFixedLength()
                .HasComment("H = High, M = Medium, L = Low");
            entity.Property(e => e.Color).HasComment("Product color.");
            entity.Property(e => e.DaysToManufacture).HasComment("Number of days required to manufacture the product.");
            entity.Property(e => e.DiscontinuedDate).HasComment("Date the product was discontinued.");
            entity.Property(e => e.FinishedGoodsFlag)
                .HasDefaultValueSql("((1))")
                .HasComment("0 = Product is not a salable item. 1 = Product is salable.");
            entity.Property(e => e.ListPrice).HasComment("Selling price.");
            entity.Property(e => e.MakeFlag)
                .HasDefaultValueSql("((1))")
                .HasComment("0 = Product is purchased, 1 = Product is manufactured in-house.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.");
            entity.Property(e => e.Name).HasComment("Name of the product.");
            entity.Property(e => e.ProductLine)
                .IsFixedLength()
                .HasComment("R = Road, M = Mountain, T = Touring, S = Standard");
            entity.Property(e => e.ProductModelId).HasComment("Product is a member of this product model. Foreign key to ProductModel.ProductModelID.");
            entity.Property(e => e.ProductNumber).HasComment("Unique product identification number.");
            entity.Property(e => e.ProductSubcategoryId).HasComment("Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID. ");
            entity.Property(e => e.ReorderPoint).HasComment("Inventory level that triggers a purchase order or work order. ");
            entity.Property(e => e.Rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
            entity.Property(e => e.SafetyStockLevel).HasComment("Minimum inventory quantity. ");
            entity.Property(e => e.SellEndDate).HasComment("Date the product was no longer available for sale.");
            entity.Property(e => e.SellStartDate).HasComment("Date the product was available for sale.");
            entity.Property(e => e.Size).HasComment("Product size.");
            entity.Property(e => e.SizeUnitMeasureCode)
                .IsFixedLength()
                .HasComment("Unit of measure for Size column.");
            entity.Property(e => e.StandardCost).HasComment("Standard cost of the product.");
            entity.Property(e => e.Style)
                .IsFixedLength()
                .HasComment("W = Womens, M = Mens, U = Universal");
            entity.Property(e => e.Weight).HasComment("Product weight.");
            entity.Property(e => e.WeightUnitMeasureCode)
                .IsFixedLength()
                .HasComment("Unit of measure for Weight column.");
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasKey(e => e.ProductCategoryId).HasName("PK_ProductCategory_ProductCategoryID");

            entity.ToTable("ProductCategory", "Production", tb => tb.HasComment("High-level product categorization."));

            entity.Property(e => e.ProductCategoryId).HasComment("Primary key for ProductCategory records.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.");
            entity.Property(e => e.Name).HasComment("Category description.");
            entity.Property(e => e.Rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
        });

        modelBuilder.Entity<ProductSubcategory>(entity =>
        {
            entity.HasKey(e => e.ProductSubcategoryId).HasName("PK_ProductSubcategory_ProductSubcategoryID");

            entity.ToTable("ProductSubcategory", "Production", tb => tb.HasComment("Product subcategories. See ProductCategory table."));

            entity.Property(e => e.ProductSubcategoryId).HasComment("Primary key for ProductSubcategory records.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.");
            entity.Property(e => e.Name).HasComment("Subcategory description.");
            entity.Property(e => e.ProductCategoryId).HasComment("Product category identification number. Foreign key to ProductCategory.ProductCategoryID.");
            entity.Property(e => e.Rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            entity.HasOne(d => d.ProductCategory).WithMany(p => p.ProductSubcategories).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<SalesOrderDetail>(entity =>
        {
            entity.HasKey(e => new { e.SalesOrderId, e.SalesOrderDetailId }).HasName("PK_SalesOrderDetail_SalesOrderID_SalesOrderDetailID");

            entity.ToTable("SalesOrderDetail", "Sales", tb =>
                {
                    tb.HasComment("Individual products associated with a specific sales order. See SalesOrderHeader.");
                    tb.HasTrigger("iduSalesOrderDetail");
                });

            entity.Property(e => e.SalesOrderId).HasComment("Primary key. Foreign key to SalesOrderHeader.SalesOrderID.");
            entity.Property(e => e.SalesOrderDetailId)
                .ValueGeneratedOnAdd()
                .HasComment("Primary key. One incremental unique number per product sold.");
            entity.Property(e => e.CarrierTrackingNumber).HasComment("Shipment tracking number supplied by the shipper.");
            entity.Property(e => e.LineTotal)
                .HasComputedColumnSql("(isnull(([UnitPrice]*((1.0)-[UnitPriceDiscount]))*[OrderQty],(0.0)))", false)
                .HasComment("Per product subtotal. Computed as UnitPrice * (1 - UnitPriceDiscount) * OrderQty.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.");
            entity.Property(e => e.OrderQty).HasComment("Quantity ordered per product.");
            entity.Property(e => e.ProductId).HasComment("Product sold to customer. Foreign key to Product.ProductID.");
            entity.Property(e => e.Rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
            entity.Property(e => e.SpecialOfferId).HasComment("Promotional code. Foreign key to SpecialOffer.SpecialOfferID.");
            entity.Property(e => e.UnitPrice).HasComment("Selling price of a single product.");
            entity.Property(e => e.UnitPriceDiscount).HasComment("Discount amount.");
        });

        OnModelCreatingPartial(modelBuilder);
    }
   
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
