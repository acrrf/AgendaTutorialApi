// <auto-generated />
using System;
using AgendaTutorialApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgendaTutorialApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221212001923_DisponibilidadeUpdateTable")]
    partial class DisponibilidadeUpdateTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AgendaTutorialApi.Models.Agendamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataAgendamento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DisciplnaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("HoraAgendamento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DisciplnaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Agendamentos");
                });

            modelBuilder.Entity("AgendaTutorialApi.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Disciplinas");
                });

            modelBuilder.Entity("AgendaTutorialApi.Models.Disponibilidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataDisponibilidade")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DisciplinaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Disponibilidades");
                });

            modelBuilder.Entity("AgendaTutorialApi.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Email = "ana.felippe3@etec.sp.gov.br",
                            Login = "AnaClaudia",
                            Nome = "Ana Claudia",
                            TipoUsuario = 1
                        },
                        new
                        {
                            Id = 3,
                            Email = "maroyofelippe@gmail.com",
                            Login = "mrroyo",
                            Nome = "Marco Royo",
                            TipoUsuario = 1
                        },
                        new
                        {
                            Id = 4,
                            Email = "rafaelTutor@gmail.com",
                            Login = "rafaroyo",
                            Nome = "Rafael Royo",
                            TipoUsuario = 3
                        },
                        new
                        {
                            Id = 1,
                            Nome = "Admin",
                            PasswordHash = new byte[] { 214, 51, 7, 108, 141, 245, 247, 166, 75, 84, 127, 124, 235, 50, 74, 239, 119, 212, 122, 227, 68, 53, 218, 233, 153, 185, 197, 248, 241, 180, 71, 73, 5, 93, 20, 250, 18, 86, 240, 221, 81, 244, 32, 17, 113, 237, 188, 22, 137, 126, 165, 245, 227, 27, 2, 240, 205, 230, 222, 195, 39, 193, 76, 170 },
                            PasswordSalt = new byte[] { 185, 226, 107, 9, 61, 15, 28, 250, 69, 211, 3, 106, 38, 160, 169, 33, 45, 160, 51, 164, 11, 203, 2, 180, 253, 247, 156, 10, 164, 81, 130, 10, 65, 166, 134, 149, 33, 162, 59, 102, 29, 204, 1, 229, 124, 139, 84, 180, 55, 210, 2, 241, 217, 52, 28, 206, 86, 163, 130, 2, 105, 149, 159, 97, 254, 125, 158, 245, 79, 65, 209, 56, 225, 202, 58, 151, 111, 140, 231, 169, 136, 8, 217, 38, 111, 43, 160, 251, 94, 106, 82, 69, 162, 241, 203, 65, 93, 151, 221, 134, 42, 135, 16, 89, 216, 253, 137, 56, 176, 210, 193, 246, 88, 68, 107, 184, 159, 68, 240, 8, 226, 121, 177, 255, 62, 203, 177, 125 },
                            Senha = "",
                            TipoUsuario = 4
                        });
                });

            modelBuilder.Entity("AgendaTutorialApi.Models.Agendamento", b =>
                {
                    b.HasOne("AgendaTutorialApi.Models.Disciplina", "Disciplna")
                        .WithMany()
                        .HasForeignKey("DisciplnaId");

                    b.HasOne("AgendaTutorialApi.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Disciplna");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("AgendaTutorialApi.Models.Disponibilidade", b =>
                {
                    b.HasOne("AgendaTutorialApi.Models.Disciplina", "Disciplina")
                        .WithMany()
                        .HasForeignKey("DisciplinaId");

                    b.HasOne("AgendaTutorialApi.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Disciplina");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
