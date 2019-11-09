﻿// <auto-generated />
using SQLiteEF.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace SQLiteEF.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20180610234411_ServicosCreate")]
    partial class ServicosCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("OficinaModels.Cadastros.Cliente", b =>
                {
                    b.Property<long?>("ClienteID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EMail");

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.HasKey("ClienteID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("OficinaModels.Cadastros.Servico", b =>
                {
                    b.Property<long?>("ServicoID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<double>("Valor");

                    b.HasKey("ServicoID");

                    b.ToTable("Servicos");
                });
#pragma warning restore 612, 618
        }
    }
}
