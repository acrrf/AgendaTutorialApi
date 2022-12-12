namespace AgendaTutorialApi.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public DateTime DataAgendamento { get; set; }
        public DateTime HoraAgendamento { get; set; }

        public Usuario? Usuario { get; set; }
        public Disciplina? Disciplna { get; set; }
    }
}