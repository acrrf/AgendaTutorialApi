using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaTutorialApi.Migrations
{
    /// <inheritdoc />
    public partial class AgendaDisp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Disciplinas_DisciplnaId",
                table: "Agendamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Usuarios_UsuarioId",
                table: "Agendamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Disponibilidades_Disciplinas_DisciplinaId",
                table: "Disponibilidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Disponibilidades_Usuarios_UsuarioId",
                table: "Disponibilidades");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_DisciplnaId",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "DisciplnaId",
                table: "Agendamentos");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Disponibilidades",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DisciplinaId",
                table: "Disponibilidades",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Agendamentos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "disciplinaId",
                table: "Agendamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 123, 234, 236, 176, 83, 63, 108, 67, 43, 96, 167, 73, 92, 53, 102, 237, 216, 180, 185, 242, 217, 35, 168, 43, 19, 71, 129, 14, 154, 13, 168, 12, 214, 160, 187, 109, 2, 50, 204, 27, 91, 242, 143, 200, 180, 59, 164, 1, 178, 188, 236, 51, 9, 212, 60, 220, 122, 62, 42, 68, 28, 144, 157, 169 }, new byte[] { 75, 229, 194, 208, 135, 195, 65, 250, 204, 246, 180, 94, 67, 29, 59, 173, 78, 128, 7, 219, 41, 255, 107, 237, 58, 81, 161, 73, 219, 16, 196, 125, 158, 66, 68, 43, 74, 186, 74, 113, 19, 13, 227, 116, 215, 234, 139, 83, 242, 33, 43, 36, 81, 133, 84, 105, 31, 144, 52, 122, 160, 63, 149, 244, 117, 11, 247, 247, 53, 156, 176, 152, 217, 51, 85, 238, 129, 216, 11, 44, 60, 51, 34, 227, 84, 249, 22, 140, 66, 165, 250, 86, 103, 166, 9, 92, 142, 178, 86, 117, 54, 122, 79, 41, 205, 41, 32, 155, 127, 27, 112, 71, 151, 33, 220, 209, 204, 45, 194, 150, 209, 44, 97, 102, 29, 113, 210, 16 } });

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_disciplinaId",
                table: "Agendamentos",
                column: "disciplinaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Disciplinas_disciplinaId",
                table: "Agendamentos",
                column: "disciplinaId",
                principalTable: "Disciplinas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Usuarios_UsuarioId",
                table: "Agendamentos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Disponibilidades_Disciplinas_DisciplinaId",
                table: "Disponibilidades",
                column: "DisciplinaId",
                principalTable: "Disciplinas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Disponibilidades_Usuarios_UsuarioId",
                table: "Disponibilidades",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Disciplinas_disciplinaId",
                table: "Agendamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Usuarios_UsuarioId",
                table: "Agendamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Disponibilidades_Disciplinas_DisciplinaId",
                table: "Disponibilidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Disponibilidades_Usuarios_UsuarioId",
                table: "Disponibilidades");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_disciplinaId",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "disciplinaId",
                table: "Agendamentos");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Disponibilidades",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DisciplinaId",
                table: "Disponibilidades",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Agendamentos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DisciplnaId",
                table: "Agendamentos",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 214, 51, 7, 108, 141, 245, 247, 166, 75, 84, 127, 124, 235, 50, 74, 239, 119, 212, 122, 227, 68, 53, 218, 233, 153, 185, 197, 248, 241, 180, 71, 73, 5, 93, 20, 250, 18, 86, 240, 221, 81, 244, 32, 17, 113, 237, 188, 22, 137, 126, 165, 245, 227, 27, 2, 240, 205, 230, 222, 195, 39, 193, 76, 170 }, new byte[] { 185, 226, 107, 9, 61, 15, 28, 250, 69, 211, 3, 106, 38, 160, 169, 33, 45, 160, 51, 164, 11, 203, 2, 180, 253, 247, 156, 10, 164, 81, 130, 10, 65, 166, 134, 149, 33, 162, 59, 102, 29, 204, 1, 229, 124, 139, 84, 180, 55, 210, 2, 241, 217, 52, 28, 206, 86, 163, 130, 2, 105, 149, 159, 97, 254, 125, 158, 245, 79, 65, 209, 56, 225, 202, 58, 151, 111, 140, 231, 169, 136, 8, 217, 38, 111, 43, 160, 251, 94, 106, 82, 69, 162, 241, 203, 65, 93, 151, 221, 134, 42, 135, 16, 89, 216, 253, 137, 56, 176, 210, 193, 246, 88, 68, 107, 184, 159, 68, 240, 8, 226, 121, 177, 255, 62, 203, 177, 125 } });

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_DisciplnaId",
                table: "Agendamentos",
                column: "DisciplnaId");

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
    }
}
