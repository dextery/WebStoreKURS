﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebStoreKURS.Data;

namespace WebStoreKURS.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20221213131109_Initial")]
    partial class Initial
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

            modelBuilder.Entity("WebStoreKURS.Data.Models.Parts", b =>
                {
                    b.HasOne("WebStoreKURS.Data.Models.Categories", "Category")
                        .WithMany("parts")
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WebStoreKURS.Data.Models.Categories", b =>
                {
                    b.Navigation("parts");
                });
#pragma warning restore 612, 618
        }
    }
}
