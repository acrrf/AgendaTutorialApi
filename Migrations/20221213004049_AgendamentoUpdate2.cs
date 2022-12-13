using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaTutorialApi.Migrations
{
    /// <inheritdoc />
    public partial class AgendamentoUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Disciplinas_disciplinaId",
                table: "Agendamentos");

            migrationBuilder.RenameColumn(
                name: "disciplinaId",
                table: "Agendamentos",
                newName: "DisciplinaId");

            migrationBuilder.RenameIndex(
                name: "IX_Agendamentos_disciplinaId",
                table: "Agendamentos",
                newName: "IX_Agendamentos_DisciplinaId");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 26, 104, 78, 89, 144, 250, 75, 165, 163, 192, 8, 167, 88, 4, 59, 245, 249, 212, 182, 117, 25, 100, 5, 4, 242, 197, 252, 245, 42, 195, 115, 65, 71, 159, 11, 110, 66, 107, 160, 63, 67, 87, 185, 251, 140, 124, 73, 166, 128, 254, 67, 222, 79, 123, 195, 91, 31, 53, 127, 149, 245, 172, 201, 30 }, new byte[] { 93, 32, 33, 120, 133, 25, 94, 131, 217, 153, 87, 231, 243, 133, 171, 227, 127, 15, 63, 160, 66, 141, 121, 93, 125, 11, 154, 188, 21, 190, 92, 126, 41, 13, 49, 76, 203, 32, 207, 204, 249, 92, 87, 95, 190, 84, 153, 95, 56, 239, 149, 26, 32, 78, 195, 2, 158, 130, 167, 49, 97, 104, 84, 226, 209, 26, 174, 42, 196, 155, 29, 48, 51, 221, 233, 246, 191, 185, 163, 23, 72, 54, 232, 131, 47, 234, 197, 81, 9, 31, 34, 112, 194, 53, 10, 91, 104, 34, 103, 51, 198, 7, 133, 223, 251, 31, 220, 21, 28, 173, 139, 189, 44, 121, 66, 144, 181, 78, 160, 66, 210, 240, 182, 135, 245, 172, 8, 235 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Disciplinas_DisciplinaId",
                table: "Agendamentos",
                column: "DisciplinaId",
                principalTable: "Disciplinas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Disciplinas_DisciplinaId",
                table: "Agendamentos");

            migrationBuilder.RenameColumn(
                name: "DisciplinaId",
                table: "Agendamentos",
                newName: "disciplinaId");

            migrationBuilder.RenameIndex(
                name: "IX_Agendamentos_DisciplinaId",
                table: "Agendamentos",
                newName: "IX_Agendamentos_disciplinaId");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 232, 231, 227, 199, 146, 125, 142, 208, 103, 75, 169, 221, 197, 1, 249, 228, 8, 189, 98, 111, 141, 62, 4, 28, 197, 28, 25, 106, 32, 112, 113, 5, 115, 17, 197, 114, 101, 163, 242, 54, 214, 92, 61, 211, 68, 37, 121, 249, 90, 91, 230, 121, 0, 84, 152, 14, 1, 127, 28, 173, 38, 66, 13, 138 }, new byte[] { 141, 204, 90, 224, 107, 233, 154, 52, 179, 145, 38, 248, 119, 156, 27, 215, 98, 133, 222, 126, 71, 36, 56, 31, 175, 81, 228, 156, 46, 87, 62, 107, 98, 253, 88, 125, 177, 6, 38, 72, 84, 26, 183, 230, 152, 74, 33, 156, 246, 226, 236, 136, 1, 87, 4, 178, 34, 73, 224, 165, 205, 211, 223, 130, 120, 182, 251, 198, 35, 158, 87, 3, 109, 199, 185, 141, 171, 136, 94, 130, 249, 187, 76, 119, 215, 243, 19, 236, 173, 198, 119, 211, 189, 160, 17, 75, 219, 235, 82, 140, 152, 235, 50, 247, 45, 115, 199, 165, 132, 200, 2, 225, 35, 107, 118, 232, 222, 58, 252, 158, 116, 199, 20, 77, 41, 69, 227, 135 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Disciplinas_disciplinaId",
                table: "Agendamentos",
                column: "disciplinaId",
                principalTable: "Disciplinas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
