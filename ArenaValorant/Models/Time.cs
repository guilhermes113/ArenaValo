using ArenaValorant.Models.Interface;

namespace ArenaValorant.Models
{
    public class Time : IEntidade
    {
        

        public Time( string nome, string descricao, string membros, string imagemURL )
        {
            Nome = nome;
            Descricao = descricao;
            Membros = membros;
            ImageURL = imagemURL;
        }
        
        public Time(string nome, string descricao, string membros, string imagemURL, int jogadorId , int treinadorId)
        {
            Nome = nome;
            Descricao = descricao;
            Membros = membros;
            ImageURL = imagemURL;
            JogadorId = jogadorId;
            TreinadorId = treinadorId;
        }


        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public string Membros { get; private set; }
        public string ImageURL { get; private set; }

        #region Relacionamentos
        public int JogadorId { get; set; }
        public Jogador Jogador { get; set; }

        public int TreinadorId { get; set; }
        public Treinador Treinador { get; set; }

        public List<JogadorTime> JogadoresTimes { get; set; }
        public List<TreinadorTime> TreinadoresTimes { get; set; }
        #endregion
    }
}
