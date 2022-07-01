namespace ArenaValorant.Models
{
    public class PatenteJogador
    {
        public PatenteJogador(int patenteId, int jogadorId)
        {
            PatenteId = patenteId;
            JogadorId = jogadorId;
        }

        public int PatenteId { get; set; }
        public Patente Patente { get; set; }

        public int JogadorId { get; set; }
        public Jogador Jogador { get; set; }
    }
}
