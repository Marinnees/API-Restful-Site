﻿// <auto-generated />
using System;
using Agencia_viajar.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Agencia_viajar.Migrations
{
    [DbContext(typeof(AgenciaDbContext))]
    [Migration("20221101130219_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Agencia_viajar.Model.Passagem", b =>
                {
                    b.Property<int>("PassagemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PassagemId"), 1L, 1);

                    b.Property<DateTime>("Data_passagem")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desembarque")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Embarque")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Empresa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Valor_passagem")
                        .HasColumnType("float");

                    b.HasKey("PassagemId");

                    b.ToTable("Passagem");
                });
#pragma warning restore 612, 618
        }
    }
}
