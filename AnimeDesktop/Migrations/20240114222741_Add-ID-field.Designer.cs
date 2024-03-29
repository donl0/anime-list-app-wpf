﻿// <auto-generated />
using AnimeDesktop.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AnimeDesktop.Migrations
{
    [DbContext(typeof(DBClient))]
    [Migration("20240114222741_Add-ID-field")]
    partial class AddIDfield
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AnimeDesktop.DB.Model.AbandonedAnime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("AnimeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("AbandonedAnime");
                });

            modelBuilder.Entity("AnimeDesktop.DB.Model.PlannedAnime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("AnimeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("PlannedAnime");
                });

            modelBuilder.Entity("AnimeDesktop.DB.Model.UserRating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("AnimeId")
                        .HasColumnType("bigint");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("UserRating");
                });

            modelBuilder.Entity("AnimeDesktop.DB.Model.WatchedAnime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("AnimeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("WatchedAnime");
                });
#pragma warning restore 612, 618
        }
    }
}
