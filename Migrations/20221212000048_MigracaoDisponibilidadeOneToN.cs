using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaTutorialApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoDisponibilidadeOneToN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisciplinaId",
                table: "Disponibilidades",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Disponibilidades",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 56, 149, 140, 246, 230, 9, 67, 155, 150, 202, 246, 157, 80, 154, 128, 141, 128, 246, 115, 64, 181, 163, 120, 185, 170, 136, 76, 78, 17, 66, 116, 77, 66, 117, 15, 50, 198, 109, 148, 5, 0, 77, 17, 107, 144, 143, 131, 0, 167, 68, 227, 83, 172, 134, 224, 54, 143, 44, 159, 46, 182, 59, 245, 72 }, new byte[] { 175, 103, 167, 48, 241, 89, 217, 101, 134, 58, 73, 37, 32, 20, 142, 122, 100, 30, 231, 180, 175, 209, 179, 226, 41, 52, 16, 21, 100, 121, 39, 3, 61, 247, 149, 221, 139, 244, 110, 78, 75, 50, 163, 42, 158, 33, 156, 115, 94, 63, 216, 229, 114, 206, 94, 179, 103, 100, 236, 94, 206, 105, 208, 195, 13, 154, 136, 75, 215, 218, 6, 34, 115, 176, 41, 62, 216, 248, 208, 91, 84, 228, 47, 8, 169, 175, 197, 84, 163, 65, 62, 231, 65, 114, 115, 169, 197, 218, 193, 79, 202, 60, 30, 135, 133, 14, 163, 233, 5, 249, 102, 166, 48, 195, 22, 192, 156, 80, 145, 238, 126, 100, 59, 96, 156, 11, 25, 118 } });

            migrationBuilder.CreateIndex(
                name: "IX_Disponibilidades_DisciplinaId",
                table: "Disponibilidades",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Disponibilidades_UsuarioId",
                table: "Disponibilidades",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Disponibilidades_Disciplinas_DisciplinaId",
                table: "Disponibilidades",
                column: "DisciplinaId",
                principalTable: "Disciplinas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Disponibilidades_Usuarios_UsuarioId",
                table: "Disponibilidades",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disponibilidades_Disciplinas_DisciplinaId",
                table: "Disponibilidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Disponibilidades_Usuarios_UsuarioId",
                table: "Disponibilidades");

            migrationBuilder.DropIndex(
                name: "IX_Disponibilidades_DisciplinaId",
                table: "Disponibilidades");

            migrationBuilder.DropIndex(
                name: "IX_Disponibilidades_UsuarioId",
                table: "Disponibilidades");

            migrationBuilder.DropColumn(
                name: "DisciplinaId",
                table: "Disponibilidades");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Disponibilidades");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 32, 170, 24, 223, 212, 64, 225, 145, 101, 7, 92, 14, 100, 221, 108, 149, 58, 99, 96, 128, 229, 128, 98, 12, 180, 109, 224, 147, 78, 194, 153, 177, 194, 78, 182, 108, 215, 46, 251, 46, 132, 199, 109, 70, 100, 35, 37, 86, 106, 95, 136, 168, 88, 137, 25, 224, 88, 171, 86, 47, 79, 3, 167, 13 }, new byte[] { 143, 147, 190, 193, 27, 1, 135, 246, 37, 227, 68, 123, 228, 224, 54, 36, 40, 98, 96, 223, 253, 170, 11, 98, 79, 207, 32, 158, 149, 206, 193, 93, 214, 105, 140, 48, 95, 173, 132, 6, 146, 55, 56, 163, 225, 206, 60, 191, 128, 26, 125, 207, 50, 79, 16, 163, 165, 246, 117, 70, 135, 123, 12, 245, 59, 45, 78, 7, 86, 117, 97, 37, 31, 44, 170, 80, 124, 241, 41, 72, 51, 120, 99, 124, 107, 102, 215, 195, 132, 196, 243, 61, 235, 237, 170, 111, 126, 42, 104, 227, 227, 47, 238, 33, 179, 138, 246, 91, 145, 21, 159, 202, 31, 163, 144, 178, 107, 147, 110, 121, 194, 24, 78, 238, 48, 208, 98, 91 } });
        }
    }
}
