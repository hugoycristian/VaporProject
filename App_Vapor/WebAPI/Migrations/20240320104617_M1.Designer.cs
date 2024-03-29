﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Context;

#nullable disable

namespace WebAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240320104617_M1")]
    partial class M1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAPI.Models.Biblioteca", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("FechaAdicion")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdJuego")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IdJuego");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Bibliotecas");
                });

            modelBuilder.Entity("WebAPI.Models.Carrito", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("FechaAdicion")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdJuego")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IdJuego");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Carritos");
                });

            modelBuilder.Entity("WebAPI.Models.Desarrollador", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Desarrolladores");
                });

            modelBuilder.Entity("WebAPI.Models.Editor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Editores");
                });

            modelBuilder.Entity("WebAPI.Models.Genero", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("WebAPI.Models.GeneroJuego", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("IdGenero")
                        .HasColumnType("int");

                    b.Property<int>("IdJuego")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IdGenero");

                    b.HasIndex("IdJuego");

                    b.ToTable("GenerosJuegos");
                });

            modelBuilder.Entity("WebAPI.Models.Juego", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaLanzamiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDesarrollador")
                        .HasColumnType("int");

                    b.Property<int>("IdEditor")
                        .HasColumnType("int");

                    b.Property<double>("Puntuacion")
                        .HasColumnType("float");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("IdDesarrollador");

                    b.HasIndex("IdEditor");

                    b.ToTable("Juegos");
                });

            modelBuilder.Entity("WebAPI.Models.JuegoTransaccion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("IdJuego")
                        .HasColumnType("int");

                    b.Property<int>("IdTransaccion")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IdJuego");

                    b.HasIndex("IdTransaccion");

                    b.ToTable("JuegosTransacciones");
                });

            modelBuilder.Entity("WebAPI.Models.Resenya", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdJuego")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("Valoracion")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IdJuego");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Resenyas");
                });

            modelBuilder.Entity("WebAPI.Models.Transaccion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("FechaCompra")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<decimal>("Importe")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Transacciones");
                });

            modelBuilder.Entity("WebAPI.Models.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomApels")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("WebAPI.Models.Biblioteca", b =>
                {
                    b.HasOne("WebAPI.Models.Juego", "Juego")
                        .WithMany("Bibliotecas")
                        .HasForeignKey("IdJuego")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.Usuario", "Usuario")
                        .WithMany("Bibliotecas")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Juego");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("WebAPI.Models.Carrito", b =>
                {
                    b.HasOne("WebAPI.Models.Juego", "Juego")
                        .WithMany("Carritos")
                        .HasForeignKey("IdJuego")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.Usuario", "Usuario")
                        .WithMany("Carritos")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Juego");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("WebAPI.Models.GeneroJuego", b =>
                {
                    b.HasOne("WebAPI.Models.Genero", "Genero")
                        .WithMany("GenerosJuegos")
                        .HasForeignKey("IdGenero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.Juego", "Juego")
                        .WithMany("GenerosJuegos")
                        .HasForeignKey("IdJuego")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");

                    b.Navigation("Juego");
                });

            modelBuilder.Entity("WebAPI.Models.Juego", b =>
                {
                    b.HasOne("WebAPI.Models.Desarrollador", "Desarrollador")
                        .WithMany("Juegos")
                        .HasForeignKey("IdDesarrollador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.Editor", "Editor")
                        .WithMany("Juegos")
                        .HasForeignKey("IdEditor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Desarrollador");

                    b.Navigation("Editor");
                });

            modelBuilder.Entity("WebAPI.Models.JuegoTransaccion", b =>
                {
                    b.HasOne("WebAPI.Models.Juego", "Juego")
                        .WithMany("JuegosTransacciones")
                        .HasForeignKey("IdJuego")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.Transaccion", "Transaccion")
                        .WithMany("JuegosTransacciones")
                        .HasForeignKey("IdTransaccion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Juego");

                    b.Navigation("Transaccion");
                });

            modelBuilder.Entity("WebAPI.Models.Resenya", b =>
                {
                    b.HasOne("WebAPI.Models.Juego", "Juego")
                        .WithMany("Resenyas")
                        .HasForeignKey("IdJuego")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.Usuario", "Usuario")
                        .WithMany("Resenyas")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Juego");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("WebAPI.Models.Transaccion", b =>
                {
                    b.HasOne("WebAPI.Models.Usuario", "Usuario")
                        .WithMany("Transacciones")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("WebAPI.Models.Desarrollador", b =>
                {
                    b.Navigation("Juegos");
                });

            modelBuilder.Entity("WebAPI.Models.Editor", b =>
                {
                    b.Navigation("Juegos");
                });

            modelBuilder.Entity("WebAPI.Models.Genero", b =>
                {
                    b.Navigation("GenerosJuegos");
                });

            modelBuilder.Entity("WebAPI.Models.Juego", b =>
                {
                    b.Navigation("Bibliotecas");

                    b.Navigation("Carritos");

                    b.Navigation("GenerosJuegos");

                    b.Navigation("JuegosTransacciones");

                    b.Navigation("Resenyas");
                });

            modelBuilder.Entity("WebAPI.Models.Transaccion", b =>
                {
                    b.Navigation("JuegosTransacciones");
                });

            modelBuilder.Entity("WebAPI.Models.Usuario", b =>
                {
                    b.Navigation("Bibliotecas");

                    b.Navigation("Carritos");

                    b.Navigation("Resenyas");

                    b.Navigation("Transacciones");
                });
#pragma warning restore 612, 618
        }
    }
}
