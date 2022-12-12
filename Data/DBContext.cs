using AgendaTutorialApi.Models;
using AgendaTutorialApi.Models.Enuns;
using AgendaTutorialApi.Utils;
using Microsoft.EntityFrameworkCore;

namespace AgendaTutorialApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Agendamento>? Agendamentos { get; set; }
        public DbSet<Disciplina>? Disciplinas { get; set; }
        public DbSet<Disponibilidade>? Disponibilidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuario> ().HasData
            (
                new Usuario() {Id = 2, Nome = "Ana Claudia", Login = "AnaClaudia", Email = "ana.felippe3@etec.sp.gov.br", TipoUsuario = TipoUsuario.Aluno},
                new Usuario() {Id = 3, Nome = "Marco Royo", Login = "mrroyo", Email = "maroyofelippe@gmail.com", TipoUsuario = TipoUsuario.Aluno},
                new Usuario() {Id = 4, Nome = "Rafael Royo", Login = "rafaroyo", Email = "rafaelTutor@gmail.com", TipoUsuario = TipoUsuario.Tutor}
            );

            //Início da criação do usuário padrão.
            Usuario user = new Usuario();
            Criptografia.CriarPasswordHash("Ana@230379", out byte[] hash, out byte[] salt);
            user.Id = 1;
            user.Nome = "Admin";
            user.Senha = string.Empty;
            user.PasswordHash = hash;
            user.PasswordSalt = salt;
            user.TipoUsuario = TipoUsuario.Admin;

            modelBuilder.Entity<Usuario>().HasData(user);
            //Fim da criação do usuário padrão.   

            //Define que se o Perfil não for informado, o valor padrão será jogador
            modelBuilder.Entity<Usuario>().Property(u => u.TipoUsuario).HasDefaultValue(TipoUsuario.Aluno);

        }

    }
}