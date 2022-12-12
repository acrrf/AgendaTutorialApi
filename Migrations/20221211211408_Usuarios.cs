using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgendaTutorialApi.Migrations
{
    /// <inheritdoc />
    public partial class Usuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agendamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataAgendamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraAgendamento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Disponibilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataDisponibilidade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraDisponibilidade = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disponibilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    TipoUsuario = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "Login", "Nome", "PasswordHash", "PasswordSalt", "Senha", "TipoUsuario" },
                values: new object[,]
                {
                    { 1, null, null, "Admin", new byte[] { 155, 191, 18, 231, 10, 146, 147, 20, 232, 7, 224, 114, 8, 199, 204, 39, 36, 242, 243, 148, 186, 245, 95, 142, 176, 163, 150, 125, 153, 205, 174, 93, 103, 152, 154, 138, 96, 176, 167, 82, 211, 184, 34, 232, 134, 94, 243, 8, 204, 163, 142, 181, 238, 76, 82, 178, 241, 108, 199, 53, 252, 1, 177, 209 }, new byte[] { 252, 230, 212, 254, 31, 19, 165, 142, 96, 250, 217, 112, 98, 112, 229, 59, 249, 112, 217, 167, 240, 14, 234, 31, 113, 113, 83, 26, 91, 155, 65, 67, 12, 46, 42, 180, 112, 141, 11, 183, 35, 209, 234, 11, 93, 197, 87, 11, 39, 32, 239, 248, 209, 224, 71, 20, 47, 131, 62, 199, 102, 50, 217, 2, 212, 51, 86, 241, 255, 192, 24, 84, 178, 181, 201, 65, 7, 210, 48, 88, 194, 255, 148, 215, 128, 251, 153, 250, 107, 48, 82, 78, 189, 142, 45, 108, 202, 120, 5, 20, 174, 104, 79, 6, 18, 197, 195, 89, 173, 223, 130, 214, 239, 106, 9, 204, 232, 185, 6, 170, 41, 16, 28, 206, 190, 55, 103, 109 }, "", 4 },
                    { 2, "ana.felippe3@etec.sp.gov.br", "AnaClaudia", "Ana Claudia", null, null, null, 1 },
                    { 3, "maroyofelippe@gmail.com", "mrroyo", "Marco Royo", null, null, null, 1 },
                    { 4, "rafaelTutor@gmail.com", "rafaroyo", "Rafael Royo", null, null, null, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamentos");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Disponibilidades");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
