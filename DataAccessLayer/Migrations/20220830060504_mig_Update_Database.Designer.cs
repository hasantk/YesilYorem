﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220830060504_mig_Update_Database")]
    partial class mig_Update_Database
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminAbout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Basket", b =>
                {
                    b.Property<int>("BasketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BasketStatus")
                        .HasColumnType("bit");

                    b.Property<int>("ProductCount")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.HasKey("BasketId");

                    b.HasIndex("ProductId");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CommentCreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CommentTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductSkor")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("ProductId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<DateTime>("ProductCreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ProductStatus")
                        .HasColumnType("bit");

                    b.Property<int>("ProductStok")
                        .HasColumnType("int");

                    b.Property<string>("ProductThumbnailImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ProductRayting", b =>
                {
                    b.Property<int>("ProductRaytingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductRaytingCount")
                        .HasColumnType("int");

                    b.Property<int>("ProductTotalScore")
                        .HasColumnType("int");

                    b.HasKey("ProductRaytingId");

                    b.ToTable("ProductRaytings");
                });

            modelBuilder.Entity("EntityLayer.Concrete.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminAbout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("UserStatus")
                        .HasColumnType("bit");

                    b.Property<string>("UserSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Basket", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Product", "products")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("products");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Product", "product")
                        .WithMany("comment")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Product", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Category", "categories")
                        .WithMany("product")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.User", "users")
                        .WithMany("product")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categories");

                    b.Navigation("users");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Navigation("product");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Product", b =>
                {
                    b.Navigation("comment");
                });

            modelBuilder.Entity("EntityLayer.Concrete.User", b =>
                {
                    b.Navigation("product");
                });
#pragma warning restore 612, 618
        }
    }
}