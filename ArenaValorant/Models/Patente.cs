using ArenaValorant.Models.Interface;

namespace ArenaValorant.Models
{
    public class Patente : IEntidade
    {
        public Patente(string nome)
        {
            Nome = nome;
        }

        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Nome { get; protected private set; }
        public List<PatenteJogador> PatentesJogadores { get; set; }

        public void AtualizarDados(string nome)
        {
            Nome = nome;
            DataAlteracao = DateTime.Now;
        }
    }
}

