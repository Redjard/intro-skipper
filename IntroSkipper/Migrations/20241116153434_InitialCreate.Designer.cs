﻿// <auto-generated />
using System;
using IntroSkipper.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntroSkipper.Migrations
{
    [DbContext(typeof(IntroSkipperDbContext))]
    [Migration("20241116153434_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("IntroSkipper.Db.DbSeasonInfo", b =>
                {
                    b.Property<Guid>("SeasonId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Action")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(0);

                    b.Property<string>("EpisodeIds")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SeasonId", "Type");

                    b.HasIndex("SeasonId");

                    b.ToTable("DbSeasonInfo", (string)null);
                });

            modelBuilder.Entity("IntroSkipper.Db.DbSegment", b =>
                {
                    b.Property<Guid>("ItemId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<double>("End")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("REAL")
                        .HasDefaultValue(0.0);

                    b.Property<double>("Start")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("REAL")
                        .HasDefaultValue(0.0);

                    b.HasKey("ItemId", "Type");

                    b.HasIndex("ItemId");

                    b.ToTable("DbSegment", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
