namespace AgendaTutorialApi.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public DateTime DataAgendamento { get; set; }
        public Usuario? Usuario { get; set; }
        public Disciplina? Disciplina { get; set; }
        public int UsuarioId { get; set; }
        public int DisciplinaId { get; set; }
    }
}