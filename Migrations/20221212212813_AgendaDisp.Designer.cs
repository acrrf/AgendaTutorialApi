﻿// <auto-generated />
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
    [Migration("20221212212813_AgendaDisp")]
    partial class AgendaDisp
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

                    b.Property<DateTime>("HoraAgendamento")
                        .HasColumnType("datetime2");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("disciplinaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("disciplinaId");

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

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
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
                            PasswordHash = new byte[] { 123, 234, 236, 176, 83, 63, 108, 67, 43, 96, 167, 73, 92, 53, 102, 237, 216, 180, 185, 242, 217, 35, 168, 43, 19, 71, 129, 14, 154, 13, 168, 12, 214, 160, 187, 109, 2, 50, 204, 27, 91, 242, 143, 200, 180, 59, 164, 1, 178, 188, 236, 51, 9, 212, 60, 220, 122, 62, 42, 68, 28, 144, 157, 169 },
                            PasswordSalt = new byte[] { 75, 229, 194, 208, 135, 195, 65, 250, 204, 246, 180, 94, 67, 29, 59, 173, 78, 128, 7, 219, 41, 255, 107, 237, 58, 81, 161, 73, 219, 16, 196, 125, 158, 66, 68, 43, 74, 186, 74, 113, 19, 13, 227, 116, 215, 234, 139, 83, 242, 33, 43, 36, 81, 133, 84, 105, 31, 144, 52, 122, 160, 63, 149, 244, 117, 11, 247, 247, 53, 156, 176, 152, 217, 51, 85, 238, 129, 216, 11, 44, 60, 51, 34, 227, 84, 249, 22, 140, 66, 165, 250, 86, 103, 166, 9, 92, 142, 178, 86, 117, 54, 122, 79, 41, 205, 41, 32, 155, 127, 27, 112, 71, 151, 33, 220, 209, 204, 45, 194, 150, 209, 44, 97, 102, 29, 113, 210, 16 },
                            Senha = "",
                            TipoUsuario = 4
                        });
                });

            modelBuilder.Entity("AgendaTutorialApi.Models.Agendamento", b =>
                {
                    b.HasOne("AgendaTutorialApi.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AgendaTutorialApi.Models.Disciplina", "Disciplna")
                        .WithMany()
                        .HasForeignKey("disciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disciplna");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("AgendaTutorialApi.Models.Disponibilidade", b =>
                {
                    b.HasOne("AgendaTutorialApi.Models.Disciplina", "Disciplina")
                        .WithMany()
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AgendaTutorialApi.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disciplina");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
