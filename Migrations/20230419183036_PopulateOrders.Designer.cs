﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NTTData.Data;

#nullable disable

namespace nttdata.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230419183036_PopulateOrders")]
    partial class PopulateOrders
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NTTData.Models.Address", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("complement")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("neighborhood")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("zipCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("id");

                    b.HasIndex("ClientId");

                    b.ToTable("tb_addresses");
                });

            modelBuilder.Entity("NTTData.Models.Client", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.HasKey("id");

                    b.ToTable("tb_clients");
                });

            modelBuilder.Entity("NTTData.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("instant")
                        .HasColumnType("datetime(6)");

                    b.HasKey("id");

                    b.HasIndex("ClientId");

                    b.ToTable("tb_orders");
                });

            modelBuilder.Entity("NTTData.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("tb_products");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<int>("Ordersid")
                        .HasColumnType("int");

                    b.Property<int>("Productsid")
                        .HasColumnType("int");

                    b.HasKey("Ordersid", "Productsid");

                    b.HasIndex("Productsid");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("NTTData.Models.Address", b =>
                {
                    b.HasOne("NTTData.Models.Client", "Client")
                        .WithMany("Addresses")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("NTTData.Models.Order", b =>
                {
                    b.HasOne("NTTData.Models.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("NTTData.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("Ordersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NTTData.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("Productsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NTTData.Models.Client", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
