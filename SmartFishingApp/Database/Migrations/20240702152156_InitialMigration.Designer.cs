﻿// <auto-generated />
using System;
using Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Database.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240702152156_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Models.Entities.UserProfile.FishingReel.FishingReel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Brand")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Commentary")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("bytea");

                    b.Property<int?>("ReelTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int?>("TypeOfFishingId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ReelTypeId");

                    b.HasIndex("TypeOfFishingId");

                    b.ToTable("FishingReels", (string)null);
                });

            modelBuilder.Entity("Models.Entities.UserProfile.FishingReel.FishingReelType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Commentary")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("FishingReelTypes", (string)null);
                });

            modelBuilder.Entity("SmartFishingApp.Models.Rod.Rod", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Brand")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Class")
                        .HasColumnType("text");

                    b.Property<string>("Commentary")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Length")
                        .HasColumnType("text");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("bytea");

                    b.Property<int?>("RodTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("Test")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int?>("TypeOfFishingId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RodTypeId");

                    b.HasIndex("TypeOfFishingId");

                    b.ToTable("Rods", (string)null);
                });

            modelBuilder.Entity("SmartFishingApp.Models.Rod.RodType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Commentary")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("RodTypes", (string)null);
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Commentary")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("TypeOfFishingId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TypeOfFishingId");

                    b.ToTable("TackleCategories", (string)null);
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Feeder.FeederAlive", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Commentary")
                        .HasColumnType("text");

                    b.Property<string>("Lure")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NozzleType")
                        .HasColumnType("text");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("bytea");

                    b.Property<int>("TackleCategoryId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TackleCategoryId");

                    b.ToTable("FeederAlives", (string)null);
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Feeder.FeederBoil", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Brand")
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Commentary")
                        .HasColumnType("text");

                    b.Property<string>("Lure")
                        .HasColumnType("text");

                    b.Property<string>("Model")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("bytea");

                    b.Property<double?>("Size")
                        .HasColumnType("double precision");

                    b.Property<int>("TackleCategoryId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TackleCategoryId");

                    b.ToTable("FeederBoils", (string)null);
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Feeder.FeederCorn", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Commentary")
                        .HasColumnType("text");

                    b.Property<string>("Lure")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NozzleType")
                        .HasColumnType("text");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("bytea");

                    b.Property<int>("TackleCategoryId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TackleCategoryId");

                    b.ToTable("FeederCorns", (string)null);
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Float.FloatAlive", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Commentary")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NozzleType")
                        .HasColumnType("text");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("bytea");

                    b.Property<int>("TackleCategoryId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TackleCategoryId");

                    b.ToTable("FloatAlives", (string)null);
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Float.FloatCorn", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Commentary")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NozzleType")
                        .HasColumnType("text");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("bytea");

                    b.Property<int>("TackleCategoryId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TackleCategoryId");

                    b.ToTable("FloatCorns", (string)null);
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Spinning.SpinningJig", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Brand")
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Commentary")
                        .HasColumnType("text");

                    b.Property<string>("Form")
                        .HasColumnType("text");

                    b.Property<double?>("Length")
                        .HasColumnType("double precision");

                    b.Property<string>("Model")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("bytea");

                    b.Property<int>("TackleCategoryId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TackleCategoryId");

                    b.ToTable("SpinningJigs", (string)null);
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Spinning.SpinningSpoon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Brand")
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Commentary")
                        .HasColumnType("text");

                    b.Property<string>("Form")
                        .HasColumnType("text");

                    b.Property<string>("Model")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("bytea");

                    b.Property<double?>("SizeNumber")
                        .HasColumnType("double precision");

                    b.Property<int>("TackleCategoryId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TackleCategoryId");

                    b.ToTable("SpinningSpoons", (string)null);
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Spinning.SpinningVobler", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Brand")
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Commentary")
                        .HasColumnType("text");

                    b.Property<double?>("Depenning")
                        .HasColumnType("double precision");

                    b.Property<string>("Flotation")
                        .HasColumnType("text");

                    b.Property<double?>("Length")
                        .HasColumnType("double precision");

                    b.Property<string>("Model")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("bytea");

                    b.Property<int>("TackleCategoryId")
                        .HasColumnType("integer");

                    b.Property<double?>("Weight")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("TackleCategoryId");

                    b.ToTable("SpinningVoblers", (string)null);
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Winter.WinterJig", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Brand")
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Commentary")
                        .HasColumnType("text");

                    b.Property<double?>("Form")
                        .HasColumnType("double precision");

                    b.Property<string>("Model")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("bytea");

                    b.Property<int>("TackleCategoryId")
                        .HasColumnType("integer");

                    b.Property<double?>("Weight")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("TackleCategoryId");

                    b.ToTable("WinterJigs", (string)null);
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Winter.WinterRocker", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Brand")
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Commentary")
                        .HasColumnType("text");

                    b.Property<double?>("Length")
                        .HasColumnType("double precision");

                    b.Property<string>("Model")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("bytea");

                    b.Property<int>("TackleCategoryId")
                        .HasColumnType("integer");

                    b.Property<double?>("Weight")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("TackleCategoryId");

                    b.ToTable("WinterRockers", (string)null);
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Winter.WinterSpoon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Brand")
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Commentary")
                        .HasColumnType("text");

                    b.Property<double?>("Length")
                        .HasColumnType("double precision");

                    b.Property<string>("Model")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("bytea");

                    b.Property<int>("TackleCategoryId")
                        .HasColumnType("integer");

                    b.Property<double?>("Weight")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("TackleCategoryId");

                    b.ToTable("WinterSpoons", (string)null);
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Winter.WinterVobler", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Brand")
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Commentary")
                        .HasColumnType("text");

                    b.Property<double?>("Length")
                        .HasColumnType("double precision");

                    b.Property<string>("Model")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("bytea");

                    b.Property<int>("TackleCategoryId")
                        .HasColumnType("integer");

                    b.Property<double?>("Weight")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("TackleCategoryId");

                    b.ToTable("WinterVoblers", (string)null);
                });

            modelBuilder.Entity("SmartFishingApp.Models.TypeOfFishing.TypeOfFishing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Commentary")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TypesOfFishing", (string)null);
                });

            modelBuilder.Entity("Models.Entities.UserProfile.FishingReel.FishingReel", b =>
                {
                    b.HasOne("Models.Entities.UserProfile.FishingReel.FishingReelType", "ReelType")
                        .WithMany()
                        .HasForeignKey("ReelTypeId");

                    b.HasOne("SmartFishingApp.Models.TypeOfFishing.TypeOfFishing", "TypeOfFishing")
                        .WithMany()
                        .HasForeignKey("TypeOfFishingId");

                    b.Navigation("ReelType");

                    b.Navigation("TypeOfFishing");
                });

            modelBuilder.Entity("SmartFishingApp.Models.Rod.Rod", b =>
                {
                    b.HasOne("SmartFishingApp.Models.Rod.RodType", "RodType")
                        .WithMany()
                        .HasForeignKey("RodTypeId");

                    b.HasOne("SmartFishingApp.Models.TypeOfFishing.TypeOfFishing", "TypeOfFishing")
                        .WithMany("Rods")
                        .HasForeignKey("TypeOfFishingId");

                    b.Navigation("RodType");

                    b.Navigation("TypeOfFishing");
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleCategory", b =>
                {
                    b.HasOne("SmartFishingApp.Models.TypeOfFishing.TypeOfFishing", "TypeOfFishing")
                        .WithMany("TackleCategories")
                        .HasForeignKey("TypeOfFishingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeOfFishing");
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Feeder.FeederAlive", b =>
                {
                    b.HasOne("SmartFishingApp.Models.Tackle.TackleCategory", "TackleCategory")
                        .WithMany()
                        .HasForeignKey("TackleCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TackleCategory");
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Feeder.FeederBoil", b =>
                {
                    b.HasOne("SmartFishingApp.Models.Tackle.TackleCategory", "TackleCategory")
                        .WithMany()
                        .HasForeignKey("TackleCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TackleCategory");
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Feeder.FeederCorn", b =>
                {
                    b.HasOne("SmartFishingApp.Models.Tackle.TackleCategory", "TackleCategory")
                        .WithMany()
                        .HasForeignKey("TackleCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TackleCategory");
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Float.FloatAlive", b =>
                {
                    b.HasOne("SmartFishingApp.Models.Tackle.TackleCategory", "TackleCategory")
                        .WithMany()
                        .HasForeignKey("TackleCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TackleCategory");
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Float.FloatCorn", b =>
                {
                    b.HasOne("SmartFishingApp.Models.Tackle.TackleCategory", "TackleCategory")
                        .WithMany()
                        .HasForeignKey("TackleCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TackleCategory");
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Spinning.SpinningJig", b =>
                {
                    b.HasOne("SmartFishingApp.Models.Tackle.TackleCategory", "TackleCategory")
                        .WithMany()
                        .HasForeignKey("TackleCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TackleCategory");
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Spinning.SpinningSpoon", b =>
                {
                    b.HasOne("SmartFishingApp.Models.Tackle.TackleCategory", "TackleCategory")
                        .WithMany()
                        .HasForeignKey("TackleCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TackleCategory");
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Spinning.SpinningVobler", b =>
                {
                    b.HasOne("SmartFishingApp.Models.Tackle.TackleCategory", "TackleCategory")
                        .WithMany()
                        .HasForeignKey("TackleCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TackleCategory");
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Winter.WinterJig", b =>
                {
                    b.HasOne("SmartFishingApp.Models.Tackle.TackleCategory", "TackleCategory")
                        .WithMany()
                        .HasForeignKey("TackleCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TackleCategory");
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Winter.WinterRocker", b =>
                {
                    b.HasOne("SmartFishingApp.Models.Tackle.TackleCategory", "TackleCategory")
                        .WithMany()
                        .HasForeignKey("TackleCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TackleCategory");
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Winter.WinterSpoon", b =>
                {
                    b.HasOne("SmartFishingApp.Models.Tackle.TackleCategory", "TackleCategory")
                        .WithMany()
                        .HasForeignKey("TackleCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TackleCategory");
                });

            modelBuilder.Entity("SmartFishingApp.Models.Tackle.TackleTypes.Winter.WinterVobler", b =>
                {
                    b.HasOne("SmartFishingApp.Models.Tackle.TackleCategory", "TackleCategory")
                        .WithMany()
                        .HasForeignKey("TackleCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TackleCategory");
                });

            modelBuilder.Entity("SmartFishingApp.Models.TypeOfFishing.TypeOfFishing", b =>
                {
                    b.Navigation("Rods");

                    b.Navigation("TackleCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
