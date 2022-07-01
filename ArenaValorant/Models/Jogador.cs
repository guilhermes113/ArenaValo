namespace ArenaValorant.Models
{
    public class Jogador : Perfil
    {
        public Jogador(string nome, string bio, string fotoPerfilURL, string patente)
            : base(nome, bio, fotoPerfilURL, patente)
        {}
        public List<JogadorTime> JogadoresTimes { get; set; }
        public List<PatenteJogador> PatentesJogadores { get; set; }
    }
}
