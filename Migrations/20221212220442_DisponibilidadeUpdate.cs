using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaTutorialApi.Migrations
{
    /// <inheritdoc />
    public partial class DisponibilidadeUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoraAgendamento",
                table: "Agendamentos");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 234, 104, 54, 74, 226, 32, 34, 130, 83, 106, 116, 48, 5, 3, 228, 68, 115, 181, 155, 26, 72, 142, 135, 75, 173, 173, 232, 68, 18, 194, 96, 130, 163, 44, 253, 247, 41, 44, 34, 96, 117, 81, 87, 197, 42, 18, 189, 165, 36, 189, 197, 240, 241, 242, 235, 248, 153, 223, 90, 138, 11, 157, 179, 18 }, new byte[] { 0, 139, 192, 38, 29, 166, 110, 63, 157, 205, 126, 38, 117, 43, 107, 95, 244, 241, 67, 13, 41, 244, 166, 44, 138, 191, 6, 182, 80, 29, 38, 198, 153, 241, 45, 109, 182, 87, 34, 201, 255, 0, 242, 246, 195, 77, 224, 197, 220, 73, 55, 114, 27, 180, 23, 132, 196, 93, 153, 143, 248, 183, 161, 218, 85, 134, 160, 76, 9, 165, 208, 56, 32, 246, 4, 221, 99, 83, 123, 141, 161, 141, 68, 90, 143, 8, 83, 197, 238, 247, 0, 197, 189, 239, 182, 67, 212, 234, 2, 32, 124, 215, 105, 176, 69, 24, 217, 110, 38, 231, 1, 129, 60, 19, 251, 109, 29, 3, 121, 137, 218, 142, 45, 77, 213, 118, 200, 252 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "HoraAgendamento",
                table: "Agendamentos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 123, 234, 236, 176, 83, 63, 108, 67, 43, 96, 167, 73, 92, 53, 102, 237, 216, 180, 185, 242, 217, 35, 168, 43, 19, 71, 129, 14, 154, 13, 168, 12, 214, 160, 187, 109, 2, 50, 204, 27, 91, 242, 143, 200, 180, 59, 164, 1, 178, 188, 236, 51, 9, 212, 60, 220, 122, 62, 42, 68, 28, 144, 157, 169 }, new byte[] { 75, 229, 194, 208, 135, 195, 65, 250, 204, 246, 180, 94, 67, 29, 59, 173, 78, 128, 7, 219, 41, 255, 107, 237, 58, 81, 161, 73, 219, 16, 196, 125, 158, 66, 68, 43, 74, 186, 74, 113, 19, 13, 227, 116, 215, 234, 139, 83, 242, 33, 43, 36, 81, 133, 84, 105, 31, 144, 52, 122, 160, 63, 149, 244, 117, 11, 247, 247, 53, 156, 176, 152, 217, 51, 85, 238, 129, 216, 11, 44, 60, 51, 34, 227, 84, 249, 22, 140, 66, 165, 250, 86, 103, 166, 9, 92, 142, 178, 86, 117, 54, 122, 79, 41, 205, 41, 32, 155, 127, 27, 112, 71, 151, 33, 220, 209, 204, 45, 194, 150, 209, 44, 97, 102, 29, 113, 210, 16 } });
        }
    }
}
