﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PallidaOrientationExam.Entities;
using System;

namespace PallidaOrientationExam.Migrations
{
    [DbContext(typeof(PlateContext))]
    [Migration("20180129213913_changeyeartoint")]
    partial class changeyeartoint
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PallidaOrientationExam.Models.Plates", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CarBrand");

                    b.Property<string>("CarModel");

                    b.Property<string>("Color");

                    b.Property<string>("Plate");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("LicensePlates");
                });
#pragma warning restore 612, 618
        }
    }
}
