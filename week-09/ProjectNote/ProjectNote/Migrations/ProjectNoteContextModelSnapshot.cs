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
    partial class ProjectNoteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectNote.Models.Project", b =>
                {
                    b.Property<long?>("projectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("description");

                    b.Property<string>("link");

                    b.Property<string>("programmingLanguage");

                    b.Property<long?>("userId");

                    b.HasKey("projectId");

                    b.HasIndex("userId");

                    b.ToTable("projects");
                });

            modelBuilder.Entity("ProjectNote.Models.User", b =>
                {
                    b.Property<long?>("userId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("greenfoxClass");

                    b.Property<string>("name");

                    b.Property<string>("password");

                    b.HasKey("userId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("ProjectNote.Models.Project", b =>
                {
                    b.HasOne("ProjectNote.Models.User", "user")
                        .WithMany("projects")
                        .HasForeignKey("userId");
                });
#pragma warning restore 612, 618
        }
    }
}