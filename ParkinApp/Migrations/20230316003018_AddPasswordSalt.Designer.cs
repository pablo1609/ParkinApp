﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkinApp.Data;

#nullable disable

namespace ParkinApp.Migrations
{
    [DbContext(typeof(ParkingDbContext))]
    [Migration("20230316003018_AddPasswordSalt")]
    partial class AddPasswordSalt
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("ParkingApp.Entities.ParkingSpot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsReserved")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ReservationEndTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ReservationTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("TimeZoneId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ParkingSpots");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsReserved = false,
                            TimeZoneId = "UTC+1"
                        },
                        new
                        {
                            Id = 2,
                            IsReserved = false,
                            TimeZoneId = "UTC+1"
                        },
                        new
                        {
                            Id = 3,
                            IsReserved = false,
                            TimeZoneId = "UTC+1"
                        },
                        new
                        {
                            Id = 4,
                            IsReserved = false,
                            TimeZoneId = "UTC+1"
                        },
                        new
                        {
                            Id = 5,
                            IsReserved = false,
                            TimeZoneId = "UTC+1"
                        },
                        new
                        {
                            Id = 6,
                            IsReserved = false,
                            TimeZoneId = "UTC+1"
                        },
                        new
                        {
                            Id = 7,
                            IsReserved = false,
                            TimeZoneId = "UTC+1"
                        },
                        new
                        {
                            Id = 8,
                            IsReserved = false,
                            TimeZoneId = "UTC+1"
                        },
                        new
                        {
                            Id = 9,
                            IsReserved = false,
                            TimeZoneId = "UTC+1"
                        },
                        new
                        {
                            Id = 10,
                            IsReserved = false,
                            TimeZoneId = "UTC+1"
                        });
                });

            modelBuilder.Entity("ParkingApp.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<int?>("ReservedSpotId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserTimeZoneId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ReservedSpotId")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ParkingApp.Entities.User", b =>
                {
                    b.HasOne("ParkingApp.Entities.ParkingSpot", "ReservedSpot")
                        .WithOne("User")
                        .HasForeignKey("ParkingApp.Entities.User", "ReservedSpotId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("ReservedSpot");
                });

            modelBuilder.Entity("ParkingApp.Entities.ParkingSpot", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
