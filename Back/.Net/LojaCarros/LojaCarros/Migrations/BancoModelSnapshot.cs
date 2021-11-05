﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LojaCarros.Migrations
{
    [DbContext(typeof(Banco))]
    partial class BancoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LojaCarros.Models.Carro", b =>
                {
                    b.Property<int>("CarroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano")
                        .HasColumnType("Integer")
                        .HasColumnName("Ano");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)")
                        .HasColumnName("Nome");

                    b.HasKey("CarroId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Carros");
                });

            modelBuilder.Entity("LojaCarros.Models.Cidade", b =>
                {
                    b.Property<int>("CidadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnoFundacao")
                        .HasColumnType("Integer");

                    b.Property<string>("Nome")
                        .HasColumnType("Varchar(50)");

                    b.HasKey("CidadeId");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("LojaCarros.Models.Cliente", b =>
                {
                    b.Property<int>("ClientesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("DateTime")
                        .HasColumnName("DataNascimento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("Varchar(50)")
                        .HasColumnName("Nome");

                    b.Property<string>("Telefone")
                        .HasColumnType("Varchar(20)")
                        .HasColumnName("Telefone");

                    b.HasKey("ClientesId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("LojaCarros.Models.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)")
                        .HasColumnName("Nome");

                    b.HasKey("MarcaId");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("LojaCarros.Models.Carro", b =>
                {
                    b.HasOne("LojaCarros.Models.Marca", "Marca")
                        .WithMany("Carros")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("LojaCarros.Models.Marca", b =>
                {
                    b.Navigation("Carros");
                });
#pragma warning restore 612, 618
        }
    }
}