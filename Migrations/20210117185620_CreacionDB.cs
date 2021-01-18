using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prueba_Web.Migrations
{
    public partial class CreacionDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id_cliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(maxLength: 50, nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id_cliente);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Usuarios",
                columns: table => new
                {
                    Id_tipo_usuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Usuarios", x => x.Id_tipo_usuario);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id_usuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(maxLength: 50, nullable: false),
                    Carnet = table.Column<string>(maxLength: 7, nullable: false),
                    Pass = table.Column<string>(nullable: false),
                    Estado = table.Column<bool>(nullable: false),
                    Id_tipo_usuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id_usuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Tipos_Usuarios_Id_tipo_usuario",
                        column: x => x.Id_tipo_usuario,
                        principalTable: "Tipos_Usuarios",
                        principalColumn: "Id_tipo_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Control_Actividades",
                columns: table => new
                {
                    Id_control_actividad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha_actividad = table.Column<DateTime>(nullable: false),
                    Actividades = table.Column<int>(nullable: false),
                    Id_usuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Control_Actividades", x => x.Id_control_actividad);
                    table.ForeignKey(
                        name: "FK_Control_Actividades_Usuarios_Id_usuario",
                        column: x => x.Id_usuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Marcaciones",
                columns: table => new
                {
                    Id_marcacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha_marcacion = table.Column<DateTime>(nullable: false),
                    Id_usuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcaciones", x => x.Id_marcacion);
                    table.ForeignKey(
                        name: "FK_Marcaciones_Usuarios_Id_usuario",
                        column: x => x.Id_usuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permisos",
                columns: table => new
                {
                    Id_permiso = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Fecha_permiso = table.Column<DateTime>(maxLength: 50, nullable: false),
                    Estado = table.Column<bool>(nullable: false),
                    Id_usuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => x.Id_permiso);
                    table.ForeignKey(
                        name: "FK_Permisos_Usuarios_Id_usuario",
                        column: x => x.Id_usuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Control_Actividades_Id_usuario",
                table: "Control_Actividades",
                column: "Id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Marcaciones_Id_usuario",
                table: "Marcaciones",
                column: "Id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_Id_usuario",
                table: "Permisos",
                column: "Id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Id_tipo_usuario",
                table: "Usuarios",
                column: "Id_tipo_usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Control_Actividades");

            migrationBuilder.DropTable(
                name: "Marcaciones");

            migrationBuilder.DropTable(
                name: "Permisos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Tipos_Usuarios");
        }
    }
}
