﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaStore.Data;

#nullable disable

namespace PizzaStore.Migrations
{
    [DbContext(typeof(dbContext))]
    [Migration("20231210033705_FinalMigration")]
    partial class FinalMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("PizzaStore.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("PizzaStore.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Iscompleted")
                        .HasMaxLength(50)
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("OrderName");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PizzaStore.Entities.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Duedate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("ProductName");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("PizzaStore.Entities.Role", b =>
                {
                    b.Property<int>("Roleid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Roleid");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Roleid = 1,
                            RoleName = "Admin"
                        },
                        new
                        {
                            Roleid = 2,
                            RoleName = "User"
                        });
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordSalt")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "Coolcody171@gmail.com",
                            FirstName = "Cody",
                            LastName = "Criner",
                            PasswordHash = "A0A7B968A20E3FB39B1B8AA4877F29597D56FFBD907891FEEDABBF940E70633F586F67BFF07A4975CBA22A22F7F1B988F2DD1A6A4867A60AC1B25C417B3EA99C",
                            PasswordSalt = "FE5D976E712E3122CB81BBB3B85AE2DD360020C7027E30CDC3375C7C36FF6A807C11C2D9963E28F806DA5BC9A22466F4B6C523FBE104EFCFCD05C47C609CF339",
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 2,
                            Email = "Crinerc21@students.ecu.edu",
                            FirstName = "Kyle",
                            LastName = "Criner",
                            PasswordHash = "FA6BA0AE07E34A0916FFF2ECF20D995FE05A52D44A385566B45D580E61CEF66344466DC87573ABD76BCF26EC823E4F94A5C82CCFE57EE4ABD7A6073383280DA3",
                            PasswordSalt = "686981512FBED86F8EE4FE8673F899332D3D0BFCEAD08F9E4DF6359E3AB5DCAC2F66583572100E7F73439768C8AF803D2B8B45D44FCF8E00F7CC15B8B15528A7",
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("PizzaStore.Entities.Product", b =>
                {
                    b.HasOne("PizzaStore.Entities.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.HasOne("PizzaStore.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("PizzaStore.Entities.Order", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
