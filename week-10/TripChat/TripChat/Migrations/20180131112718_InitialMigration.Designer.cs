﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TripChat.Entities;
using TripChat.ViewModels;

namespace TripChat.Migrations
{
    [DbContext(typeof(TripChatViewModel))]
    [Migration("20180131112718_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TripChat.Models.Chat", b =>
                {
                    b.Property<long?>("ChatId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("TimeOfThePost");

                    b.Property<long?>("TripId");

                    b.HasKey("ChatId");

                    b.HasIndex("TripId");

                    b.ToTable("TripChats");
                });

            modelBuilder.Entity("TripChat.Models.Location", b =>
                {
                    b.Property<long?>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<long?>("TripId");

                    b.HasKey("LocationId");

                    b.HasIndex("TripId");

                    b.ToTable("TripLocations");
                });

            modelBuilder.Entity("TripChat.Models.Trip", b =>
                {
                    b.Property<long?>("TripId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DateOfTheTrip");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<DateTime>("TimeOfTripPostCreated");

                    b.HasKey("TripId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("TripChat.Models.User", b =>
                {
                    b.Property<long?>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("OrganisedTrips");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TripChat.Models.UserTrip", b =>
                {
                    b.Property<long?>("UserId");

                    b.Property<long?>("TripId");

                    b.HasKey("UserId", "TripId");

                    b.HasIndex("TripId");

                    b.ToTable("UserTrip");
                });

            modelBuilder.Entity("TripChat.Models.Chat", b =>
                {
                    b.HasOne("TripChat.Models.Trip", "Trip")
                        .WithMany("TripChats")
                        .HasForeignKey("TripId");
                });

            modelBuilder.Entity("TripChat.Models.Location", b =>
                {
                    b.HasOne("TripChat.Models.Trip", "Trip")
                        .WithMany("TripLocations")
                        .HasForeignKey("TripId");
                });

            modelBuilder.Entity("TripChat.Models.UserTrip", b =>
                {
                    b.HasOne("TripChat.Models.Trip", "Trip")
                        .WithMany("UserTrips")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TripChat.Models.User", "User")
                        .WithMany("UserTrips")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
