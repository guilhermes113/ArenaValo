using System.ComponentModel.DataAnnotations;

namespace ArenaValorant.Models
{
    public class JogadorTime
    {
        public JogadorTime(int jogadorId, int timeId)
        {
            JogadorId = jogadorId;
            TimeId = timeId;
        }

        [Key]
        public int JogadorId { get; private set; }
        public Jogador Jogador { get; set; }

        [Key]
        public int TimeId { get; private set; }
        public Time Time { get; set; }
    }
}
