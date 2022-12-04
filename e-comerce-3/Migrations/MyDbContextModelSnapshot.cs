﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using e_comerce_3.Models;

#nullable disable

namespace e_comerce_3.Migrations
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

            modelBuilder.Entity("e_comerce_3.Models.Consumer", b =>
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

            modelBuilder.Entity("e_comerce_3.Models.Payment", b =>
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

            modelBuilder.Entity("e_comerce_3.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("available")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("description")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.Property<float>("value")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("e_comerce_3.Models.Request", b =>
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

            modelBuilder.Entity("e_comerce_3.Models.CreditCard", b =>
                {
                    b.HasBaseType("e_comerce_3.Models.Payment");

                    b.Property<bool>("debitAuthorization")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("number")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("CreditCard");
                });

            modelBuilder.Entity("e_comerce_3.Models.Ticket", b =>
                {
                    b.HasBaseType("e_comerce_3.Models.Payment");

                    b.Property<string>("code")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("Ticket");
                });

            modelBuilder.Entity("e_comerce_3.Models.Payment", b =>
                {
                    b.HasOne("e_comerce_3.Models.Request", "Request")
                        .WithOne("Payment")
                        .HasForeignKey("e_comerce_3.Models.Payment", "RequestId");

                    b.Navigation("Request");
                });

            modelBuilder.Entity("e_comerce_3.Models.Request", b =>
                {
                    b.HasOne("e_comerce_3.Models.Consumer", "consumer")
                        .WithMany("Request")
                        .HasForeignKey("consumerId");

                    b.HasOne("e_comerce_3.Models.Product", "product")
                        .WithMany("items")
                        .HasForeignKey("productId");

                    b.Navigation("consumer");

                    b.Navigation("product");
                });

            modelBuilder.Entity("e_comerce_3.Models.Consumer", b =>
                {
                    b.Navigation("Request");
                });

            modelBuilder.Entity("e_comerce_3.Models.Product", b =>
                {
                    b.Navigation("items");
                });

            modelBuilder.Entity("e_comerce_3.Models.Request", b =>
                {
                    b.Navigation("Payment");
                });
#pragma warning restore 612, 618
        }
    }
}