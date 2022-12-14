using AgendaTutorialApi.Models.Enuns;

namespace AgendaTutorialApi.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Login { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
    }
}