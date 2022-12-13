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
    [Migration("20221213004049_AgendamentoUpdate2")]
    partial class AgendamentoUpdate2
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

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DisciplinaId");

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
                            PasswordHash = new byte[] { 26, 104, 78, 89, 144, 250, 75, 165, 163, 192, 8, 167, 88, 4, 59, 245, 249, 212, 182, 117, 25, 100, 5, 4, 242, 197, 252, 245, 42, 195, 115, 65, 71, 159, 11, 110, 66, 107, 160, 63, 67, 87, 185, 251, 140, 124, 73, 166, 128, 254, 67, 222, 79, 123, 195, 91, 31, 53, 127, 149, 245, 172, 201, 30 },
                            PasswordSalt = new byte[] { 93, 32, 33, 120, 133, 25, 94, 131, 217, 153, 87, 231, 243, 133, 171, 227, 127, 15, 63, 160, 66, 141, 121, 93, 125, 11, 154, 188, 21, 190, 92, 126, 41, 13, 49, 76, 203, 32, 207, 204, 249, 92, 87, 95, 190, 84, 153, 95, 56, 239, 149, 26, 32, 78, 195, 2, 158, 130, 167, 49, 97, 104, 84, 226, 209, 26, 174, 42, 196, 155, 29, 48, 51, 221, 233, 246, 191, 185, 163, 23, 72, 54, 232, 131, 47, 234, 197, 81, 9, 31, 34, 112, 194, 53, 10, 91, 104, 34, 103, 51, 198, 7, 133, 223, 251, 31, 220, 21, 28, 173, 139, 189, 44, 121, 66, 144, 181, 78, 160, 66, 210, 240, 182, 135, 245, 172, 8, 235 },
                            Senha = "",
                            TipoUsuario = 4
                        });
                });

            modelBuilder.Entity("AgendaTutorialApi.Models.Agendamento", b =>
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