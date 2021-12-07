﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tacos;

namespace Tacos.Migrations
{
    [DbContext(typeof(TacosContext))]
    [Migration("20211207092130_RequiredName")]
    partial class RequiredName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("Tacos.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int?>("TacosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TacosId");

                    b.ToTable("Ingredient");
                });

            modelBuilder.Entity("Tacos.Tacos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Tacos");
                });

            modelBuilder.Entity("Tacos.Ingredient", b =>
                {
                    b.HasOne("Tacos.Tacos", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("TacosId");
                });

            modelBuilder.Entity("Tacos.Tacos", b =>
                {
                    b.Navigation("Ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}
