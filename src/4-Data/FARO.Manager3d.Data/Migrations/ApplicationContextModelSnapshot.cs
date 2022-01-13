﻿// <auto-generated />
using System;
using FARO.Manager3d.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FARO.Manager3d.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasPostgresExtension("postgis")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("FARO.Manager3d.Domain.Models.ActualPoint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<float>("X")
                        .HasColumnType("real");

                    b.Property<float>("Y")
                        .HasColumnType("real");

                    b.Property<float>("Z")
                        .HasColumnType("real");

                    b.Property<Guid>("nominal_point_id")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("nominal_point_id");

                    b.ToTable("actual_point");
                });

            modelBuilder.Entity("FARO.Manager3d.Domain.Models.NominalPoint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<float>("X")
                        .HasColumnType("real");

                    b.Property<float>("Y")
                        .HasColumnType("real");

                    b.Property<float>("Z")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("nominal_point");
                });

            modelBuilder.Entity("FARO.Manager3d.Domain.Models.ActualPoint", b =>
                {
                    b.HasOne("FARO.Manager3d.Domain.Models.NominalPoint", "NominalPoint")
                        .WithMany("ActualPoints")
                        .HasForeignKey("nominal_point_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NominalPoint");
                });

            modelBuilder.Entity("FARO.Manager3d.Domain.Models.NominalPoint", b =>
                {
                    b.Navigation("ActualPoints");
                });
#pragma warning restore 612, 618
        }
    }
}
