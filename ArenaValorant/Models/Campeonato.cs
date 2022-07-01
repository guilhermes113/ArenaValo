using ArenaValorant.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArenaValorant.Models
{
    public class Campeonato : IEntidade
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }

        #region Relacionamentos
        public int JogadorId { get; set; }
        public Jogador Jogador { get; set; }
        public int TimeId { get; set; }
        public Time Time { get; set; }

        public int TreinadorId { get; set; }
        public Treinador Treinador { get; set; }

        public List<JogadorTime> JogadoresTimes { get; set; }
        public List<TreinadorTime> TreinadoresTimes { get; set; }
        #endregion

    }
}
