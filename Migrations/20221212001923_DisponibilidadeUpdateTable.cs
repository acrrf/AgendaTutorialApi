using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaTutorialApi.Migrations
{
    /// <inheritdoc />
    public partial class DisponibilidadeUpdateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoraDisponibilidade",
                table: "Disponibilidades");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 214, 51, 7, 108, 141, 245, 247, 166, 75, 84, 127, 124, 235, 50, 74, 239, 119, 212, 122, 227, 68, 53, 218, 233, 153, 185, 197, 248, 241, 180, 71, 73, 5, 93, 20, 250, 18, 86, 240, 221, 81, 244, 32, 17, 113, 237, 188, 22, 137, 126, 165, 245, 227, 27, 2, 240, 205, 230, 222, 195, 39, 193, 76, 170 }, new byte[] { 185, 226, 107, 9, 61, 15, 28, 250, 69, 211, 3, 106, 38, 160, 169, 33, 45, 160, 51, 164, 11, 203, 2, 180, 253, 247, 156, 10, 164, 81, 130, 10, 65, 166, 134, 149, 33, 162, 59, 102, 29, 204, 1, 229, 124, 139, 84, 180, 55, 210, 2, 241, 217, 52, 28, 206, 86, 163, 130, 2, 105, 149, 159, 97, 254, 125, 158, 245, 79, 65, 209, 56, 225, 202, 58, 151, 111, 140, 231, 169, 136, 8, 217, 38, 111, 43, 160, 251, 94, 106, 82, 69, 162, 241, 203, 65, 93, 151, 221, 134, 42, 135, 16, 89, 216, 253, 137, 56, 176, 210, 193, 246, 88, 68, 107, 184, 159, 68, 240, 8, 226, 121, 177, 255, 62, 203, 177, 125 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "HoraDisponibilidade",
                table: "Disponibilidades",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 56, 149, 140, 246, 230, 9, 67, 155, 150, 202, 246, 157, 80, 154, 128, 141, 128, 246, 115, 64, 181, 163, 120, 185, 170, 136, 76, 78, 17, 66, 116, 77, 66, 117, 15, 50, 198, 109, 148, 5, 0, 77, 17, 107, 144, 143, 131, 0, 167, 68, 227, 83, 172, 134, 224, 54, 143, 44, 159, 46, 182, 59, 245, 72 }, new byte[] { 175, 103, 167, 48, 241, 89, 217, 101, 134, 58, 73, 37, 32, 20, 142, 122, 100, 30, 231, 180, 175, 209, 179, 226, 41, 52, 16, 21, 100, 121, 39, 3, 61, 247, 149, 221, 139, 244, 110, 78, 75, 50, 163, 42, 158, 33, 156, 115, 94, 63, 216, 229, 114, 206, 94, 179, 103, 100, 236, 94, 206, 105, 208, 195, 13, 154, 136, 75, 215, 218, 6, 34, 115, 176, 41, 62, 216, 248, 208, 91, 84, 228, 47, 8, 169, 175, 197, 84, 163, 65, 62, 231, 65, 114, 115, 169, 197, 218, 193, 79, 202, 60, 30, 135, 133, 14, 163, 233, 5, 249, 102, 166, 48, 195, 22, 192, 156, 80, 145, 238, 126, 100, 59, 96, 156, 11, 25, 118 } });
        }
    }
}
