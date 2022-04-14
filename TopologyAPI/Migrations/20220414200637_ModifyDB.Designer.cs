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
    [Migration("20220414200637_ModifyDB")]
    partial class ModifyDB
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("defualt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("drain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("max")
                        .HasColumnType("int");

                    b.Property<int>("min")
                        .HasColumnType("int");

                    b.Property<string>("source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("t1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("t2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Components");
                });
#pragma warning restore 612, 618
        }
    }
}
