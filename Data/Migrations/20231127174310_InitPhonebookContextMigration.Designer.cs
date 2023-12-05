﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhoneEdit.Data;

#nullable disable

namespace PhoneEdit.Data.Migrations
{
    [DbContext(typeof(PhonebookContext))]
    [Migration("20231127174310_InitPhonebookContextMigration")]
    partial class InitPhonebookContextMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("PhoneEdit.Models.BookEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("n");

                    b.Property<string>("CityPhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("telg");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasColumnName("work");

                    b.Property<string>("LocalPhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("telm");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasColumnName("mail");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasColumnName("name");

                    b.Property<string>("PersonnelNumber")
                        .IsRequired()
                        .HasColumnType("varchar(5)")
                        .HasColumnName("tabNumber");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasColumnName("who");

                    b.Property<string>("Room")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("komnata");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("status");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("tel1", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}