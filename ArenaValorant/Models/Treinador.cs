namespace ArenaValorant.Models
{
    public class Treinador : Perfil
    {
        public Treinador(string nome, string bio, string fotoPerfilURL, string patente) 
            : base(nome, bio, fotoPerfilURL, patente)
        {
        }
        public List<TreinadorTime> TreinadoresTimes { get; set; }
    }   
}
