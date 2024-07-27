﻿// <auto-generated />
using System;
using Acceso_Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Acceso_Datos.Migrations
{
    [DbContext(typeof(MyDBcontext))]
    partial class MyDBcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entidades.DetalleFactura", b =>
                {
                    b.Property<int>("IdDetalleFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDetalleFactura"), 1L, 1);

                    b.Property<int>("CantidadComprada")
                        .HasColumnType("int");

                    b.Property<int>("IdFacturaEnDetalleFactura")
                        .HasColumnType("int");

                    b.Property<int>("IdProductoEnDetalle")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioProducto")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("IdDetalleFactura");

                    b.HasIndex("IdFacturaEnDetalleFactura");

                    b.HasIndex("IdProductoEnDetalle");

                    b.ToTable("DetalleFacturas");
                });

            modelBuilder.Entity("Entidades.Empleado", b =>
                {
                    b.Property<int>("IdEmpleado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEmpleado"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Fotografia")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salaraio")
                        .HasColumnType("float");

                    b.HasKey("IdEmpleado");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Entidades.Factura", b =>
                {
                    b.Property<int>("IdFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFactura"), 1L, 1);

                    b.Property<int>("Correlativo")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaRealizada")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdEmpleadoEnFactura")
                        .HasColumnType("int");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("IdFactura");

                    b.HasIndex("IdEmpleadoEnFactura");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("Entidades.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("IdProducto");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Entidades.DetalleFactura", b =>
                {
                    b.HasOne("Entidades.Factura", "Objeto_Factura")
                        .WithMany("Lista_DetalleFactura")
                        .HasForeignKey("IdFacturaEnDetalleFactura")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.Producto", "Objeto_Producto")
                        .WithMany("Lista_DetalleFactura")
                        .HasForeignKey("IdProductoEnDetalle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Objeto_Factura");

                    b.Navigation("Objeto_Producto");
                });

            modelBuilder.Entity("Entidades.Factura", b =>
                {
                    b.HasOne("Entidades.Empleado", "Objeto_Empleado")
                        .WithMany("Lista_Facturas")
                        .HasForeignKey("IdEmpleadoEnFactura")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Objeto_Empleado");
                });

            modelBuilder.Entity("Entidades.Empleado", b =>
                {
                    b.Navigation("Lista_Facturas");
                });

            modelBuilder.Entity("Entidades.Factura", b =>
                {
                    b.Navigation("Lista_DetalleFactura");
                });

            modelBuilder.Entity("Entidades.Producto", b =>
                {
                    b.Navigation("Lista_DetalleFactura");
                });
#pragma warning restore 612, 618
        }
    }
}
