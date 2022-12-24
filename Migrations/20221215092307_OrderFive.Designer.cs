﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebStoreKURS.Data;

namespace WebStoreKURS.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20221215092307_OrderFive")]
    partial class OrderFive
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebStoreKURS.Data.Models.Categories", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("catedesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("categoryname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("WebStoreKURS.Data.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("orderTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("WebStoreKURS.Data.Models.OrderDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("orderAIDI")
                        .HasColumnType("int");

                    b.Property<int?>("orderid")
                        .HasColumnType("int");

                    b.Property<int>("partAIDI")
                        .HasColumnType("int");

                    b.Property<int?>("partid")
                        .HasColumnType("int");

                    b.Property<long>("price")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("orderid");

                    b.HasIndex("partid");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("WebStoreKURS.Data.Models.Parts", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("categoryID")
                        .HasColumnType("int");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isFavourite")
                        .HasColumnType("bit");

                    b.Property<bool>("isavailable")
                        .HasColumnType("bit");

                    b.Property<string>("longDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("price")
                        .HasColumnType("bigint");

                    b.Property<string>("shortDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("categoryID");

                    b.ToTable("Part");
                });

            modelBuilder.Entity("WebStoreKURS.Data.Models.ShopCartItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ShopCartId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("partid")
                        .HasColumnType("int");

                    b.Property<long>("price")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("partid");

                    b.ToTable("ShopCartItem");
                });

            modelBuilder.Entity("WebStoreKURS.Data.Models.OrderDetail", b =>
                {
                    b.HasOne("WebStoreKURS.Data.Models.Order", "order")
                        .WithMany("orderDetails")
                        .HasForeignKey("orderid");

                    b.HasOne("WebStoreKURS.Data.Models.Parts", "part")
                        .WithMany()
                        .HasForeignKey("partid");

                    b.Navigation("order");

                    b.Navigation("part");
                });

            modelBuilder.Entity("WebStoreKURS.Data.Models.Parts", b =>
                {
                    b.HasOne("WebStoreKURS.Data.Models.Categories", "Category")
                        .WithMany("parts")
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WebStoreKURS.Data.Models.ShopCartItem", b =>
                {
                    b.HasOne("WebStoreKURS.Data.Models.Parts", "part")
                        .WithMany()
                        .HasForeignKey("partid");

                    b.Navigation("part");
                });

            modelBuilder.Entity("WebStoreKURS.Data.Models.Categories", b =>
                {
                    b.Navigation("parts");
                });

            modelBuilder.Entity("WebStoreKURS.Data.Models.Order", b =>
                {
                    b.Navigation("orderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
