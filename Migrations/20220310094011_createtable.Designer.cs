﻿// <auto-generated />
using System;
using ConsumerMicroservice.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsumerMicroservice.Migrations
{
    [DbContext(typeof(ConsumerDbcontext))]
    [Migration("20220310094011_createtable")]
    partial class createtable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ConsumerMicroservice.Model.Buisness", b =>
                {
                    b.Property<int>("BuisnessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BuisnessId"), 1L, 1);

                    b.Property<int>("BuisnessMasterId")
                        .HasColumnType("int");

                    b.Property<string>("BuisnessName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuisnessType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConsumerId")
                        .HasColumnType("int");

                    b.Property<int>("TotalEmployees")
                        .HasColumnType("int");

                    b.HasKey("BuisnessId");

                    b.HasIndex("BuisnessMasterId");

                    b.ToTable("Buisness");
                });

            modelBuilder.Entity("ConsumerMicroservice.Model.BuisnessMaster", b =>
                {
                    b.Property<int>("BuisnessMasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BuisnessMasterId"), 1L, 1);

                    b.Property<int>("BuisnessTurnOver")
                        .HasColumnType("int");

                    b.Property<int>("BuisnessValue")
                        .HasColumnType("int");

                    b.Property<int>("CapitalInvest")
                        .HasColumnType("int");

                    b.HasKey("BuisnessMasterId");

                    b.ToTable("BuisnessMaster");
                });

            modelBuilder.Entity("ConsumerMicroservice.Model.Consumer", b =>
                {
                    b.Property<int>("ConsumerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConsumerId"), 1L, 1);

                    b.Property<int>("AgentId")
                        .HasColumnType("int");

                    b.Property<string>("ConsumerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PanNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConsumerId");

                    b.ToTable("Consumer");
                });

            modelBuilder.Entity("ConsumerMicroservice.Model.Property", b =>
                {
                    b.Property<int>("PropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropertyId"), 1L, 1);

                    b.Property<int>("BuildingAge")
                        .HasColumnType("int");

                    b.Property<int>("BuildingStoreys")
                        .HasColumnType("int");

                    b.Property<string>("BuildingType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BuisnessId")
                        .HasColumnType("int");

                    b.Property<int>("PropertyMasterId")
                        .HasColumnType("int");

                    b.HasKey("PropertyId");

                    b.HasIndex("PropertyMasterId");

                    b.ToTable("Property");
                });

            modelBuilder.Entity("ConsumerMicroservice.Model.PropertyMaster", b =>
                {
                    b.Property<int>("PropertyMasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropertyMasterId"), 1L, 1);

                    b.Property<int>("CostOfAssest")
                        .HasColumnType("int");

                    b.Property<int>("PropertyValue")
                        .HasColumnType("int");

                    b.Property<int>("SalvageValue")
                        .HasColumnType("int");

                    b.Property<int>("UsefulLifeOfAssest")
                        .HasColumnType("int");

                    b.HasKey("PropertyMasterId");

                    b.ToTable("PropertyMaster");
                });

            modelBuilder.Entity("ConsumerMicroservice.Model.Buisness", b =>
                {
                    b.HasOne("ConsumerMicroservice.Model.BuisnessMaster", "BuisnessMaster")
                        .WithMany()
                        .HasForeignKey("BuisnessMasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BuisnessMaster");
                });

            modelBuilder.Entity("ConsumerMicroservice.Model.Property", b =>
                {
                    b.HasOne("ConsumerMicroservice.Model.PropertyMaster", "PropertyMaster")
                        .WithMany()
                        .HasForeignKey("PropertyMasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PropertyMaster");
                });
#pragma warning restore 612, 618
        }
    }
}
