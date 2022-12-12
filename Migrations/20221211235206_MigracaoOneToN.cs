using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaTutorialApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoOneToN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisciplnaId",
                table: "Agendamentos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Agendamentos",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 32, 170, 24, 223, 212, 64, 225, 145, 101, 7, 92, 14, 100, 221, 108, 149, 58, 99, 96, 128, 229, 128, 98, 12, 180, 109, 224, 147, 78, 194, 153, 177, 194, 78, 182, 108, 215, 46, 251, 46, 132, 199, 109, 70, 100, 35, 37, 86, 106, 95, 136, 168, 88, 137, 25, 224, 88, 171, 86, 47, 79, 3, 167, 13 }, new byte[] { 143, 147, 190, 193, 27, 1, 135, 246, 37, 227, 68, 123, 228, 224, 54, 36, 40, 98, 96, 223, 253, 170, 11, 98, 79, 207, 32, 158, 149, 206, 193, 93, 214, 105, 140, 48, 95, 173, 132, 6, 146, 55, 56, 163, 225, 206, 60, 191, 128, 26, 125, 207, 50, 79, 16, 163, 165, 246, 117, 70, 135, 123, 12, 245, 59, 45, 78, 7, 86, 117, 97, 37, 31, 44, 170, 80, 124, 241, 41, 72, 51, 120, 99, 124, 107, 102, 215, 195, 132, 196, 243, 61, 235, 237, 170, 111, 126, 42, 104, 227, 227, 47, 238, 33, 179, 138, 246, 91, 145, 21, 159, 202, 31, 163, 144, 178, 107, 147, 110, 121, 194, 24, 78, 238, 48, 208, 98, 91 } });

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_DisciplnaId",
                table: "Agendamentos",
                column: "DisciplnaId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_UsuarioId",
                table: "Agendamentos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Disciplinas_DisciplnaId",
                table: "Agendamentos",
                column: "DisciplnaId",
                principalTable: "Disciplinas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Usuarios_UsuarioId",
                table: "Agendamentos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Disciplinas_DisciplnaId",
                table: "Agendamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Usuarios_UsuarioId",
                table: "Agendamentos");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_DisciplnaId",
                table: "Agendamentos");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_UsuarioId",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "DisciplnaId",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Agendamentos");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 137, 72, 205, 143, 36, 255, 126, 197, 43, 37, 64, 231, 69, 172, 238, 156, 101, 57, 49, 45, 203, 82, 40, 201, 204, 50, 230, 222, 180, 235, 224, 255, 246, 51, 85, 113, 88, 35, 228, 238, 59, 239, 18, 128, 184, 25, 183, 76, 120, 122, 162, 160, 57, 140, 70, 247, 123, 63, 109, 139, 43, 69, 30, 217 }, new byte[] { 243, 241, 118, 189, 248, 243, 224, 123, 10, 54, 64, 37, 147, 198, 168, 151, 78, 124, 84, 132, 201, 169, 209, 63, 207, 124, 146, 197, 159, 59, 79, 252, 132, 76, 165, 185, 102, 11, 17, 167, 19, 42, 204, 221, 125, 158, 9, 144, 123, 154, 116, 181, 170, 215, 76, 99, 108, 75, 215, 162, 180, 229, 64, 211, 202, 158, 112, 198, 247, 61, 213, 63, 65, 45, 100, 122, 74, 131, 161, 210, 229, 103, 233, 170, 111, 144, 34, 244, 227, 158, 74, 66, 165, 110, 202, 147, 177, 255, 118, 122, 164, 114, 62, 231, 133, 149, 156, 82, 182, 8, 178, 169, 218, 204, 173, 174, 17, 49, 249, 2, 198, 99, 114, 40, 92, 149, 109, 143 } });
        }
    }
}
