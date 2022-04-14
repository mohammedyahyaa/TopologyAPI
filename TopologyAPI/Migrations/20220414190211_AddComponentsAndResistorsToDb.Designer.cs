﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TopologyAPI.Data;

namespace TopologyAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220414190211_AddComponentsAndResistorsToDb")]
    partial class AddComponentsAndResistorsToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("TopologyAPI.Models.Component", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Type");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("TopologyAPI.Models.Resistor", b =>
                {
                    b.Property<string>("defualt")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("max")
                        .HasColumnType("int");

                    b.Property<int>("min")
                        .HasColumnType("int");

                    b.HasKey("defualt");

                    b.ToTable("Resistors");
                });

            modelBuilder.Entity("TopologyAPI.Models.Component", b =>
                {
                    b.HasOne("TopologyAPI.Models.Resistor", "Resistors")
                        .WithMany()
                        .HasForeignKey("Type");

                    b.Navigation("Resistors");
                });
#pragma warning restore 612, 618
        }
    }
}