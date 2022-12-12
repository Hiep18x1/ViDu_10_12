﻿// <auto-generated />
using System;
using Intern_WebSixdo.AppDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InternWebSixdo.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221209072631_khoitao")]
    partial class khoitao
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Intern_WebSixdo.Entities.Account", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountID"));

                    b.Property<DateTime?>("AccountBorn")
                        .HasColumnType("datetime2");

                    b.Property<string>("AccountDetailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AccountStatusID")
                        .HasColumnType("int");

                    b.Property<string>("AccountUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("AcountCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RoleID")
                        .HasColumnType("int");

                    b.HasKey("AccountID");

                    b.HasIndex("AccountStatusID");

                    b.HasIndex("RoleID");

                    b.ToTable("accounts");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.AccountBag", b =>
                {
                    b.Property<int>("AccountBagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountBagId"));

                    b.Property<int?>("AccountID")
                        .HasColumnType("int");

                    b.Property<int?>("Accountd")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("AccountBagId");

                    b.HasIndex("AccountID");

                    b.HasIndex("ProductId");

                    b.ToTable("accountBags");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.AccountShipContact", b =>
                {
                    b.Property<int>("AccountShipContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountShipContactID"));

                    b.Property<string>("AccountDetailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AccountID")
                        .HasColumnType("int");

                    b.Property<string>("AccountPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AccountShipContactStatusId")
                        .HasColumnType("int");

                    b.Property<string>("ReceiverName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountShipContactID");

                    b.HasIndex("AccountID")
                        .IsUnique()
                        .HasFilter("[AccountID] IS NOT NULL");

                    b.ToTable("accountShipContacts");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.AccountStatus", b =>
                {
                    b.Property<int>("AccountStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountStatusId"));

                    b.Property<string>("AccountStatusCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountStatusDetail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountStatusId");

                    b.ToTable("accountStatuses");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillId"));

                    b.Property<int?>("AccountShipContactID")
                        .HasColumnType("int");

                    b.Property<int>("BillStatusID")
                        .HasColumnType("int");

                    b.Property<int?>("BuyMethodId")
                        .HasColumnType("int");

                    b.Property<string>("Buyernotification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CloseDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ProductReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReceivedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ShipMethodId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ShiptoBuyerDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("billCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("shipPrice")
                        .HasColumnType("int");

                    b.HasKey("BillId");

                    b.HasIndex("AccountShipContactID");

                    b.HasIndex("BillStatusID");

                    b.HasIndex("BuyMethodId");

                    b.HasIndex("ShipMethodId");

                    b.ToTable("bills");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.BillDetail", b =>
                {
                    b.Property<int>("BillDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillDetailId"));

                    b.Property<int?>("BillId")
                        .HasColumnType("int");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("BillDetailId");

                    b.HasIndex("BillId")
                        .IsUnique()
                        .HasFilter("[BillId] IS NOT NULL");

                    b.HasIndex("ProductId");

                    b.ToTable("billDetails");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.BillSales", b =>
                {
                    b.Property<int>("BillSalesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillSalesId"));

                    b.Property<int?>("BillId")
                        .HasColumnType("int");

                    b.Property<int?>("SalesId")
                        .HasColumnType("int");

                    b.HasKey("BillSalesId");

                    b.HasIndex("BillId");

                    b.HasIndex("SalesId");

                    b.ToTable("billSales");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.BillStatus", b =>
                {
                    b.Property<int>("BillStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillStatusId"));

                    b.Property<string>("BillStatusCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillStatusDetail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BillStatusId");

                    b.ToTable("billStatuses");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandId"));

                    b.Property<string>("BrandCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrandDetail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId");

                    b.ToTable("brands");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.BuyMethod", b =>
                {
                    b.Property<int>("BuyMethodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BuyMethodId"));

                    b.Property<string>("BuyMethodCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyMethodName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BuyMethodId");

                    b.ToTable("buyMethods");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.CategoryType", b =>
                {
                    b.Property<int>("CategoryTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryTypeId"));

                    b.Property<string>("SaleTypeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalesTypeDetail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryTypeId");

                    b.ToTable("categoryTypes");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColorId"));

                    b.Property<string>("ColorCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorDetail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColorId");

                    b.ToTable("colors");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.Producer", b =>
                {
                    b.Property<int>("ProducerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProducerId"));

                    b.Property<string>("ProducerCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProducerDetail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProducerId");

                    b.ToTable("producers");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("ProducerId")
                        .HasColumnType("int");

                    b.Property<string>("ProductDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductStatusId")
                        .HasColumnType("int");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("ShellPrice")
                        .HasColumnType("int");

                    b.Property<int?>("SizeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryTypeId");

                    b.HasIndex("ColorId");

                    b.HasIndex("ProducerId");

                    b.HasIndex("ProductStatusId");

                    b.HasIndex("SizeId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.ProductImg", b =>
                {
                    b.Property<int>("ProductImgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductImgId"));

                    b.Property<int?>("CountImg")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("productImg")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductImgId");

                    b.ToTable("productImgs");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.ProductStatus", b =>
                {
                    b.Property<int>("ProductStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductStatusId"));

                    b.Property<string>("ProductStatusCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductStatusDetail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductStatusId");

                    b.ToTable("productStatuses");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleDetail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.Sales", b =>
                {
                    b.Property<int>("SalesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalesId"));

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("OpenDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SalesCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SalesInt")
                        .HasColumnType("int");

                    b.Property<string>("SalesName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SalesPercent")
                        .HasColumnType("int");

                    b.Property<int?>("SalesStatusId")
                        .HasColumnType("int");

                    b.Property<int?>("SalesTypeId")
                        .HasColumnType("int");

                    b.HasKey("SalesId");

                    b.HasIndex("SalesStatusId");

                    b.HasIndex("SalesTypeId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.SalesStatus", b =>
                {
                    b.Property<int>("SalesStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalesStatusId"));

                    b.Property<string>("ProducerCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProducerDetail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalesStatusId");

                    b.ToTable("salesStatuses");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.SalesType", b =>
                {
                    b.Property<int>("SalesTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalesTypeId"));

                    b.Property<string>("SaleTypeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalesTypeDetail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalesTypeId");

                    b.ToTable("salesTypes");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.ShipMethod", b =>
                {
                    b.Property<int>("ShipMethodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShipMethodId"));

                    b.Property<string>("ShipMethodCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipMethodName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ShipPrice")
                        .HasColumnType("int");

                    b.HasKey("ShipMethodId");

                    b.ToTable("shipMethods");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.Size", b =>
                {
                    b.Property<int>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SizeId"));

                    b.Property<string>("SizeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeDetail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SizeId");

                    b.ToTable("sizes");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.VoteStar", b =>
                {
                    b.Property<int>("VoteStarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VoteStarId"));

                    b.Property<int?>("Accountid")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("StarVoted")
                        .HasColumnType("int");

                    b.HasKey("VoteStarId");

                    b.HasIndex("Accountid");

                    b.HasIndex("ProductId");

                    b.ToTable("voteStars");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.Account", b =>
                {
                    b.HasOne("Intern_WebSixdo.Entities.AccountStatus", "AccountStatus")
                        .WithMany()
                        .HasForeignKey("AccountStatusID");

                    b.HasOne("Intern_WebSixdo.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID");

                    b.Navigation("AccountStatus");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.AccountBag", b =>
                {
                    b.HasOne("Intern_WebSixdo.Entities.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountID");

                    b.HasOne("Intern_WebSixdo.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Account");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.AccountShipContact", b =>
                {
                    b.HasOne("Intern_WebSixdo.Entities.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountID");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.Bill", b =>
                {
                    b.HasOne("Intern_WebSixdo.Entities.AccountShipContact", "AccountShipContact")
                        .WithMany()
                        .HasForeignKey("AccountShipContactID");

                    b.HasOne("Intern_WebSixdo.Entities.BillStatus", "BillStatus")
                        .WithMany()
                        .HasForeignKey("BillStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Intern_WebSixdo.Entities.BuyMethod", "BuyMethod")
                        .WithMany()
                        .HasForeignKey("BuyMethodId");

                    b.HasOne("Intern_WebSixdo.Entities.ShipMethod", "ShipMethod")
                        .WithMany()
                        .HasForeignKey("ShipMethodId");

                    b.Navigation("AccountShipContact");

                    b.Navigation("BillStatus");

                    b.Navigation("BuyMethod");

                    b.Navigation("ShipMethod");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.BillDetail", b =>
                {
                    b.HasOne("Intern_WebSixdo.Entities.Bill", "Bill")
                        .WithMany()
                        .HasForeignKey("BillId");

                    b.HasOne("Intern_WebSixdo.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Bill");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.BillSales", b =>
                {
                    b.HasOne("Intern_WebSixdo.Entities.Bill", "Bill")
                        .WithMany()
                        .HasForeignKey("BillId");

                    b.HasOne("Intern_WebSixdo.Entities.Sales", "Sales")
                        .WithMany()
                        .HasForeignKey("SalesId");

                    b.Navigation("Bill");

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.Product", b =>
                {
                    b.HasOne("Intern_WebSixdo.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.HasOne("Intern_WebSixdo.Entities.CategoryType", "CategoryType")
                        .WithMany()
                        .HasForeignKey("CategoryTypeId");

                    b.HasOne("Intern_WebSixdo.Entities.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId");

                    b.HasOne("Intern_WebSixdo.Entities.Producer", "Producer")
                        .WithMany()
                        .HasForeignKey("ProducerId");

                    b.HasOne("Intern_WebSixdo.Entities.ProductStatus", "ProductStatusStatus")
                        .WithMany()
                        .HasForeignKey("ProductStatusId");

                    b.HasOne("Intern_WebSixdo.Entities.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId");

                    b.Navigation("Brand");

                    b.Navigation("CategoryType");

                    b.Navigation("Color");

                    b.Navigation("Producer");

                    b.Navigation("ProductStatusStatus");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.Sales", b =>
                {
                    b.HasOne("Intern_WebSixdo.Entities.SalesStatus", "SalesStatusStatus")
                        .WithMany()
                        .HasForeignKey("SalesStatusId");

                    b.HasOne("Intern_WebSixdo.Entities.SalesType", "SalesType")
                        .WithMany()
                        .HasForeignKey("SalesTypeId");

                    b.Navigation("SalesStatusStatus");

                    b.Navigation("SalesType");
                });

            modelBuilder.Entity("Intern_WebSixdo.Entities.VoteStar", b =>
                {
                    b.HasOne("Intern_WebSixdo.Entities.Account", "Account")
                        .WithMany()
                        .HasForeignKey("Accountid");

                    b.HasOne("Intern_WebSixdo.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Account");

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
