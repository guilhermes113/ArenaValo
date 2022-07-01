using System.ComponentModel.DataAnnotations;

namespace ArenaValorant.Models
{
    public class TreinadorTime
    {
        public TreinadorTime(int treinadorId, int timeId)
        {
            TreinadorId = treinadorId;
            TimeId = timeId;
        }

        [Key]
        public int TreinadorId { get; private set; }
        public Treinador Treinador { get; set; }

        [Key]
        public int TimeId { get; private set; }
        public Time Time { get; set; }
    }
}
