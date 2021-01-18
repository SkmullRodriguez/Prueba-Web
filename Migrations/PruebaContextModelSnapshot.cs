﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prueba_Web.Data;

namespace Prueba_Web.Migrations
{
    [DbContext(typeof(PruebaContext))]
    partial class PruebaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Prueba_Web.Models.tbl_Clientes", b =>
                {
                    b.Property<int>("Id_cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id_cliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Prueba_Web.Models.tbl_Control_actividades", b =>
                {
                    b.Property<int>("Id_control_actividad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Actividades")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha_actividad")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_usuario")
                        .HasColumnType("int");

                    b.HasKey("Id_control_actividad");

                    b.HasIndex("Id_usuario");

                    b.ToTable("Control_Actividades");
                });

            modelBuilder.Entity("Prueba_Web.Models.tbl_Marcaciones", b =>
                {
                    b.Property<int>("Id_marcacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha_marcacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_usuario")
                        .HasColumnType("int");

                    b.HasKey("Id_marcacion");

                    b.HasIndex("Id_usuario");

                    b.ToTable("Marcaciones");
                });

            modelBuilder.Entity("Prueba_Web.Models.tbl_Permisos", b =>
                {
                    b.Property<int>("Id_permiso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha_permiso")
                        .HasColumnType("datetime2")
                        .HasMaxLength(50);

                    b.Property<int>("Id_usuario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id_permiso");

                    b.HasIndex("Id_usuario");

                    b.ToTable("Permisos");
                });

            modelBuilder.Entity("Prueba_Web.Models.tbl_Tipos_usuarios", b =>
                {
                    b.Property<int>("Id_tipo_usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_tipo_usuario");

                    b.ToTable("Tipos_Usuarios");
                });

            modelBuilder.Entity("Prueba_Web.Models.tbl_Usuarios", b =>
                {
                    b.Property<int>("Id_usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Carnet")
                        .IsRequired()
                        .HasColumnType("nvarchar(7)")
                        .HasMaxLength(7);

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int>("Id_tipo_usuario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_usuario");

                    b.HasIndex("Id_tipo_usuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Prueba_Web.Models.tbl_Control_actividades", b =>
                {
                    b.HasOne("Prueba_Web.Models.tbl_Usuarios", "_Usuarios")
                        .WithMany("_Control_Actividades")
                        .HasForeignKey("Id_usuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Prueba_Web.Models.tbl_Marcaciones", b =>
                {
                    b.HasOne("Prueba_Web.Models.tbl_Usuarios", "_Usuarios")
                        .WithMany("_Marcaciones")
                        .HasForeignKey("Id_usuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Prueba_Web.Models.tbl_Permisos", b =>
                {
                    b.HasOne("Prueba_Web.Models.tbl_Usuarios", "_Usuarios")
                        .WithMany("_Permisos")
                        .HasForeignKey("Id_usuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Prueba_Web.Models.tbl_Usuarios", b =>
                {
                    b.HasOne("Prueba_Web.Models.tbl_Tipos_usuarios", "Tbl_Tipos_Usuarios")
                        .WithMany("_Tipos_Usuarios")
                        .HasForeignKey("Id_tipo_usuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
