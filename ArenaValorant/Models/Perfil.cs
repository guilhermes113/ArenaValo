using ArenaValorant.Models.Interface;

namespace ArenaValorant.Models
{
    public class Perfil : IEntidade
    {
        public Perfil(string nome, string bio, string fotoPerfilURL, string patente)
        {   
            DataCadastrado = DateTime.Now;
            DataAlteracao = DataCadastrado;
            Nome = nome;
            Bio = bio;
            FotoURL = fotoPerfilURL;
        }

        public int Id { get; set; }
        public DateTime DataCadastrado { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Nome { get; set; }
        public string Bio { get; set; }
        public string FotoURL { get; set; }

        public void AtualizarDados(string nome, string bio, string fotoURL)
        {
            Nome = nome;
            Bio = bio;
            FotoURL = fotoURL;
            DataAlteracao = System.DateTime.Now;
        }
    }
}
