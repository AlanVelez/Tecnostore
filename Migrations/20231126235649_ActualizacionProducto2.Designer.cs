﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Tecnostore.com.Data;

#nullable disable

namespace Tecnostore.com.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231126235649_ActualizacionProducto2")]
    partial class ActualizacionProducto2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Tecnostore.com.Models.Articulo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Cantidad")
                        .HasColumnType("integer");

                    b.Property<Guid>("IdCart")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdProducto")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("IdCart");

                    b.HasIndex("IdProducto");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("IdUsuario")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Categoria", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("character varying(120)");

                    b.Property<string>("Etiqueta")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Imagen")
                        .HasColumnType("text");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("fechaCreacion")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Compra", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("FechaCompra")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("IdCart")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdEnvio")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("IdCart");

                    b.HasIndex("IdEnvio");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("Tecnostore.com.Models.DireccionCliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Calle")
                        .HasColumnType("text");

                    b.Property<string>("CalleDer")
                        .HasColumnType("text");

                    b.Property<string>("CalleIzq")
                        .HasColumnType("text");

                    b.Property<string>("Ciudad")
                        .HasColumnType("text");

                    b.Property<string>("Colonia")
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.Property<string>("IdUsuario")
                        .HasColumnType("text");

                    b.Property<string>("NumeroCasa")
                        .HasColumnType("text");

                    b.Property<string>("Pais")
                        .HasColumnType("text");

                    b.Property<int>("PostalCode")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("DireccionClientes");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Envio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdDireccion")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdStatus")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("IdDireccion");

                    b.HasIndex("IdStatus");

                    b.ToTable("Envios");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Gallery", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("FechaDeSubida")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("IdProducto")
                        .HasColumnType("uuid");

                    b.Property<string>("Imagen")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdProducto");

                    b.ToTable("Gallery");
                });

            modelBuilder.Entity("Tecnostore.com.Models.HistorialCompra", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdCompra")
                        .HasColumnType("uuid");

                    b.Property<string>("IdUsuario")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdCompra");

                    b.HasIndex("IdUsuario");

                    b.ToTable("HistorialCompras");
                });

            modelBuilder.Entity("Tecnostore.com.Models.ListaFavoritos", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("FechaAgregado")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("IdProducto")
                        .HasColumnType("uuid");

                    b.Property<string>("IdUsuario")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdProducto");

                    b.HasIndex("IdUsuario");

                    b.ToTable("ListaFavoritos");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Pago", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Ciudad")
                        .HasColumnType("text");

                    b.Property<int>("CodigoPostal")
                        .HasColumnType("integer");

                    b.Property<string>("Detalles")
                        .HasColumnType("text");

                    b.Property<string>("Direccion")
                        .HasColumnType("text");

                    b.Property<Guid?>("DireccionClienteId")
                        .HasColumnType("uuid");

                    b.Property<string>("EstadoPago")
                        .HasColumnType("text");

                    b.Property<DateTime>("FechaPago")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("IdCompra")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdTipoPago")
                        .HasColumnType("uuid");

                    b.Property<string>("Pais")
                        .HasColumnType("text");

                    b.Property<decimal>("Total")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("DireccionClienteId");

                    b.HasIndex("IdCompra");

                    b.HasIndex("IdTipoPago");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Producto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Caracteristicas")
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("DescBreve")
                        .HasColumnType("text");

                    b.Property<string>("Descripcion")
                        .HasColumnType("text");

                    b.Property<string>("Etiqueta")
                        .HasColumnType("text");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("IdCategoria")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdGallery")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Marca")
                        .HasColumnType("text");

                    b.Property<decimal>("OpinionMedia")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Precio")
                        .HasColumnType("numeric");

                    b.Property<string>("Titulo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdCategoria");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Tecnostore.com.Models.ProductoEliminado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("EliminadoPor")
                        .HasColumnType("text");

                    b.Property<DateTime>("FechaEliminacion")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("IdProducto")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("EliminadoPor");

                    b.HasIndex("IdProducto");

                    b.ToTable("ProductoEliminados");
                });

            modelBuilder.Entity("Tecnostore.com.Models.ProductoView", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("FechaVisto")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("IdProducto")
                        .HasColumnType("uuid");

                    b.Property<string>("IdUsuario")
                        .HasColumnType("text");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UsuarioId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdProducto");

                    b.HasIndex("UsuarioId");

                    b.ToTable("ProductoViews");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Calificacion")
                        .HasColumnType("numeric");

                    b.Property<Guid>("IdProducto")
                        .HasColumnType("uuid");

                    b.Property<string>("IdUsuario")
                        .HasColumnType("text");

                    b.Property<string>("Opinion")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdProducto");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Tecnostore.com.Models.StatusEntrega", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("status")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("StatusEntregas");
                });

            modelBuilder.Entity("Tecnostore.com.Models.TipoPago", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Banco")
                        .HasColumnType("text");

                    b.Property<string>("CuentaAsociada")
                        .HasColumnType("text");

                    b.Property<DateTime>("FechaTarjeta")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Multinacional")
                        .HasColumnType("text");

                    b.Property<string>("NombreAsociado")
                        .HasColumnType("text");

                    b.Property<int>("NumeroTarjeta")
                        .HasColumnType("integer");

                    b.Property<string>("Pais")
                        .HasColumnType("text");

                    b.Property<string>("TipoTarjeta")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CuentaAsociada");

                    b.ToTable("TipoPagos");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Tecnostore.com.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Tecnostore.com.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tecnostore.com.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Tecnostore.com.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Tecnostore.com.Models.Articulo", b =>
                {
                    b.HasOne("Tecnostore.com.Models.Cart", "Cart")
                        .WithMany("Articulo")
                        .HasForeignKey("IdCart")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tecnostore.com.Models.Producto", "Producto")
                        .WithMany("Articulo")
                        .HasForeignKey("IdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Cart", b =>
                {
                    b.HasOne("Tecnostore.com.Models.Usuario", "Usuario")
                        .WithMany("Carts")
                        .HasForeignKey("IdUsuario");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Compra", b =>
                {
                    b.HasOne("Tecnostore.com.Models.Cart", "Cart")
                        .WithMany("Compras")
                        .HasForeignKey("IdCart")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tecnostore.com.Models.Envio", "Envio")
                        .WithMany("Compras")
                        .HasForeignKey("IdEnvio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Envio");
                });

            modelBuilder.Entity("Tecnostore.com.Models.DireccionCliente", b =>
                {
                    b.HasOne("Tecnostore.com.Models.Usuario", "Usuario")
                        .WithMany("DireccionClientes")
                        .HasForeignKey("IdUsuario");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Envio", b =>
                {
                    b.HasOne("Tecnostore.com.Models.DireccionCliente", "DireccionCliente")
                        .WithMany("Envios")
                        .HasForeignKey("IdDireccion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tecnostore.com.Models.StatusEntrega", "StatusEntrega")
                        .WithMany("Envios")
                        .HasForeignKey("IdStatus")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DireccionCliente");

                    b.Navigation("StatusEntrega");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Gallery", b =>
                {
                    b.HasOne("Tecnostore.com.Models.Producto", "Producto")
                        .WithMany("Gallery")
                        .HasForeignKey("IdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Tecnostore.com.Models.HistorialCompra", b =>
                {
                    b.HasOne("Tecnostore.com.Models.Compra", "Compra")
                        .WithMany("HistorialCompra")
                        .HasForeignKey("IdCompra")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tecnostore.com.Models.Usuario", "Usuario")
                        .WithMany("HistorialCompras")
                        .HasForeignKey("IdUsuario");

                    b.Navigation("Compra");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Tecnostore.com.Models.ListaFavoritos", b =>
                {
                    b.HasOne("Tecnostore.com.Models.Producto", "Producto")
                        .WithMany("ListaFavoritos")
                        .HasForeignKey("IdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tecnostore.com.Models.Usuario", "Usuario")
                        .WithMany("ListaFavoritos")
                        .HasForeignKey("IdUsuario");

                    b.Navigation("Producto");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Pago", b =>
                {
                    b.HasOne("Tecnostore.com.Models.DireccionCliente", null)
                        .WithMany("Pagos")
                        .HasForeignKey("DireccionClienteId");

                    b.HasOne("Tecnostore.com.Models.Compra", "Compra")
                        .WithMany("Pagos")
                        .HasForeignKey("IdCompra")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tecnostore.com.Models.TipoPago", "TipoPago")
                        .WithMany("Pagos")
                        .HasForeignKey("IdTipoPago")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compra");

                    b.Navigation("TipoPago");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Producto", b =>
                {
                    b.HasOne("Tecnostore.com.Models.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("IdCategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Tecnostore.com.Models.ProductoEliminado", b =>
                {
                    b.HasOne("Tecnostore.com.Models.Usuario", "Usuario")
                        .WithMany("ProdcutosEliminados")
                        .HasForeignKey("EliminadoPor");

                    b.HasOne("Tecnostore.com.Models.Producto", "Producto")
                        .WithMany("ProdcutoEliminado")
                        .HasForeignKey("IdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Tecnostore.com.Models.ProductoView", b =>
                {
                    b.HasOne("Tecnostore.com.Models.Producto", "Producto")
                        .WithMany("ProductoViews")
                        .HasForeignKey("IdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tecnostore.com.Models.Usuario", null)
                        .WithMany("ProductoViews")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Review", b =>
                {
                    b.HasOne("Tecnostore.com.Models.Producto", "Producto")
                        .WithMany("Review")
                        .HasForeignKey("IdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tecnostore.com.Models.Usuario", "Usuario")
                        .WithMany("Reviews")
                        .HasForeignKey("IdUsuario");

                    b.Navigation("Producto");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Tecnostore.com.Models.TipoPago", b =>
                {
                    b.HasOne("Tecnostore.com.Models.Usuario", "Usuario")
                        .WithMany("TipoPagos")
                        .HasForeignKey("CuentaAsociada");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Cart", b =>
                {
                    b.Navigation("Articulo");

                    b.Navigation("Compras");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Categoria", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Compra", b =>
                {
                    b.Navigation("HistorialCompra");

                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("Tecnostore.com.Models.DireccionCliente", b =>
                {
                    b.Navigation("Envios");

                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Envio", b =>
                {
                    b.Navigation("Compras");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Producto", b =>
                {
                    b.Navigation("Articulo");

                    b.Navigation("Gallery");

                    b.Navigation("ListaFavoritos");

                    b.Navigation("ProdcutoEliminado");

                    b.Navigation("ProductoViews");

                    b.Navigation("Review");
                });

            modelBuilder.Entity("Tecnostore.com.Models.StatusEntrega", b =>
                {
                    b.Navigation("Envios");
                });

            modelBuilder.Entity("Tecnostore.com.Models.TipoPago", b =>
                {
                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("Tecnostore.com.Models.Usuario", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("DireccionClientes");

                    b.Navigation("HistorialCompras");

                    b.Navigation("ListaFavoritos");

                    b.Navigation("ProdcutosEliminados");

                    b.Navigation("ProductoViews");

                    b.Navigation("Reviews");

                    b.Navigation("TipoPagos");
                });
#pragma warning restore 612, 618
        }
    }
}
