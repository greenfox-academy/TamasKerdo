﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ProjectNote.Entities;
using System;

namespace ProjectNote.Migrations
{
    [DbContext(typeof(ProjectNoteContext))]
    [Migration("20180125220442_Namerefactor")]
    partial class Namerefactor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectNote.Models.Project", b =>
                {
                    b.Property<long?>("ProjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Link");

                    b.Property<string>("Name");

                    b.Property<string>("ProgrammingLanguage");

                    b.Property<long?>("UserId");

                    b.HasKey("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("ProjectNote.Models.User", b =>
                {
                    b.Property<long?>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GreenfoxClass");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ProjectNote.Models.Project", b =>
                {
                    b.HasOne("ProjectNote.Models.User", "User")
                        .WithMany("Projects")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}