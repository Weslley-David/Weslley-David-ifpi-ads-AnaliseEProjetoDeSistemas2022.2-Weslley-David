﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using car_online.Models;

#nullable disable

namespace car_online.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("car_online.Models.Brand", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("car_online.Models.CarVersion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("CarVersion");
                });

            modelBuilder.Entity("car_online.Models.Consumer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("cpf")
                        .HasColumnType("longtext");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.Property<string>("phone")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Consumer");
                });

            modelBuilder.Entity("car_online.Models.Payment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("RequestId")
                        .HasColumnType("int");

                    b.Property<bool>("confirmation")
                        .HasColumnType("tinyint(1)");

                    b.Property<float>("value")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("RequestId")
                        .IsUnique();

                    b.ToTable("Payment");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Payment");
                });

            modelBuilder.Entity("car_online.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("carVersionId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.Property<bool>("used")
                        .HasColumnType("tinyint(1)");

                    b.Property<float>("value")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("BrandId");

                    b.HasIndex("carVersionId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("car_online.Models.Request", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("consumerId")
                        .HasColumnType("int");

                    b.Property<int?>("productId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("consumerId");

                    b.HasIndex("productId");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("car_online.Models.CreditCard", b =>
                {
                    b.HasBaseType("car_online.Models.Payment");

                    b.Property<bool>("debitAuthorization")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("number")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("CreditCard");
                });

            modelBuilder.Entity("car_online.Models.Ticket", b =>
                {
                    b.HasBaseType("car_online.Models.Payment");

                    b.Property<string>("code")
                        .HasColumnType("longtext");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Ticket");
                });

            modelBuilder.Entity("car_online.Models.Payment", b =>
                {
                    b.HasOne("car_online.Models.Request", "Request")
                        .WithOne("Payment")
                        .HasForeignKey("car_online.Models.Payment", "RequestId");

                    b.Navigation("Request");
                });

            modelBuilder.Entity("car_online.Models.Product", b =>
                {
                    b.HasOne("car_online.Models.Brand", "brand")
                        .WithMany("product")
                        .HasForeignKey("BrandId");

                    b.HasOne("car_online.Models.CarVersion", "carVersion")
                        .WithMany("product")
                        .HasForeignKey("carVersionId");

                    b.Navigation("brand");

                    b.Navigation("carVersion");
                });

            modelBuilder.Entity("car_online.Models.Request", b =>
                {
                    b.HasOne("car_online.Models.Consumer", "consumer")
                        .WithMany("Request")
                        .HasForeignKey("consumerId");

                    b.HasOne("car_online.Models.Product", "product")
                        .WithMany("items")
                        .HasForeignKey("productId");

                    b.Navigation("consumer");

                    b.Navigation("product");
                });

            modelBuilder.Entity("car_online.Models.Brand", b =>
                {
                    b.Navigation("product");
                });

            modelBuilder.Entity("car_online.Models.CarVersion", b =>
                {
                    b.Navigation("product");
                });

            modelBuilder.Entity("car_online.Models.Consumer", b =>
                {
                    b.Navigation("Request");
                });

            modelBuilder.Entity("car_online.Models.Product", b =>
                {
                    b.Navigation("items");
                });

            modelBuilder.Entity("car_online.Models.Request", b =>
                {
                    b.Navigation("Payment");
                });
#pragma warning restore 612, 618
        }
    }
}
