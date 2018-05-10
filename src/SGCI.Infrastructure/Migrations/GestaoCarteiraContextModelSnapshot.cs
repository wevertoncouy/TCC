﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SGCI.Infrastructure.Data;
using System;

namespace SGCI.Infrastructure.Migrations
{
    [DbContext(typeof(GestaoCarteiraContext))]
    partial class GestaoCarteiraContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SGCI.ApplicationCore.Entity.Carteira", b =>
                {
                    b.Property<int>("CarteiraId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContaId");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(230)");

                    b.Property<string>("Tipo");

                    b.Property<decimal>("Valor");

                    b.HasKey("CarteiraId");

                    b.HasIndex("ContaId");

                    b.ToTable("Carteira");
                });

            modelBuilder.Entity("SGCI.ApplicationCore.Entity.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descriao");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("SGCI.ApplicationCore.Entity.Conta", b =>
                {
                    b.Property<int>("ContaId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataInicial");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<decimal>("Saldo");

                    b.Property<string>("TipoMoeda");

                    b.HasKey("ContaId");

                    b.ToTable("Conta");
                });

            modelBuilder.Entity("SGCI.ApplicationCore.Entity.Lancamento", b =>
                {
                    b.Property<int>("LancamentoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoriaId");

                    b.Property<int>("ContaId");

                    b.Property<string>("Descricao");

                    b.Property<decimal>("Resultado");

                    b.Property<decimal>("Valor");

                    b.HasKey("LancamentoId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("ContaId");

                    b.ToTable("Lancamentos");
                });

            modelBuilder.Entity("SGCI.ApplicationCore.Entity.Carteira", b =>
                {
                    b.HasOne("SGCI.ApplicationCore.Entity.Conta", "Conta")
                        .WithMany("Carteiras")
                        .HasForeignKey("ContaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGCI.ApplicationCore.Entity.Lancamento", b =>
                {
                    b.HasOne("SGCI.ApplicationCore.Entity.Categoria", "Categoria")
                        .WithMany("Lancamentos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SGCI.ApplicationCore.Entity.Conta", "Conta")
                        .WithMany("Lancamentos")
                        .HasForeignKey("ContaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
