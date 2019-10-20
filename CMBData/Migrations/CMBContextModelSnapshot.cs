﻿// <auto-generated />
using System;
using CMBData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CMBData.Migrations
{
    [DbContext(typeof(CMBContext))]
    partial class CMBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CMBData.Models.Anuncio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<int>("AnuncianteClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModeloId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnuncianteClienteId");

                    b.HasIndex("ModeloId");

                    b.ToTable("Anuncios");
                });

            modelBuilder.Entity("CMBData.Models.AnunciosAbertos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnuncioId")
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnuncioId");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("AnunciosAbertos");
                });

            modelBuilder.Entity("CMBData.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CPF")
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("CMBData.Models.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnuncioId")
                        .HasColumnType("int");

                    b.Property<int>("CompradorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("CMBData.Models.HistoricoCompras", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int?>("CompraId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.HasIndex("CompraId");

                    b.ToTable("HistoricoCompras");
                });

            modelBuilder.Entity("CMBData.Models.Modelo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Avaliacao")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroDepesquisas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Modelos");
                });

            modelBuilder.Entity("CMBData.Models.Anuncio", b =>
                {
                    b.HasOne("CMBData.Models.Cliente", "Anunciante")
                        .WithMany()
                        .HasForeignKey("AnuncianteClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CMBData.Models.Modelo", "Modelo")
                        .WithMany()
                        .HasForeignKey("ModeloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CMBData.Models.AnunciosAbertos", b =>
                {
                    b.HasOne("CMBData.Models.Anuncio", "Anuncio")
                        .WithMany()
                        .HasForeignKey("AnuncioId");

                    b.HasOne("CMBData.Models.Cliente", "Cliente")
                        .WithOne("Anuncios")
                        .HasForeignKey("CMBData.Models.AnunciosAbertos", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CMBData.Models.HistoricoCompras", b =>
                {
                    b.HasOne("CMBData.Models.Cliente", "Cliente")
                        .WithOne("HistoricoCompras")
                        .HasForeignKey("CMBData.Models.HistoricoCompras", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CMBData.Models.Anuncio", "Compra")
                        .WithMany()
                        .HasForeignKey("CompraId");
                });
#pragma warning restore 612, 618
        }
    }
}